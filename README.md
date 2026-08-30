[![](https://img.shields.io/nuget/v/soenneker.dtos.email.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.email/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.email/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.email/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.email.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.email/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.email/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.email/actions/workflows/codeql.yml)

# Soenneker.Dtos.Email

Defines a transport-friendly email envelope with recipients, sender details, content, priority, and attachments.

## Installation

```bash
dotnet add package Soenneker.Dtos.Email
```

## Usage

```csharp
using Soenneker.Dtos.Email;
using Soenneker.Dtos.Email.Attachment;
using Soenneker.Enums.Email.Format;
using Soenneker.Enums.Email.Priority;

var email = new EmailDto
{
    To = ["customer@example.com"],
    Cc = ["account-owner@example.com"],
    ReplyTo = "support@example.com",
    Name = "Example Support",
    Address = "support@example.com",
    Subject = "Your receipt",
    Body = "<p>Thanks for your order.</p>",
    Format = EmailFormat.Html,
    Priority = EmailPriority.Normal,
    Attachments =
    [
        new EmailAttachmentDto
        {
            FileName = "receipt.pdf",
            MimeType = "application/pdf",
            Data = receiptBytes
        }
    ]
};
```

`Format` defaults to `EmailFormat.Html`; set `EmailFormat.Plaintext` for plain text. `Priority` defaults to `EmailPriority.Normal`, with `Low` and `High` also available.

## JSON shape

System.Text.Json property names are explicitly mapped to `to`, `cc`, `bcc`, `replyTo`, `name`, `address`, `subject`, `body`, `format`, `attachments`, and `priority`. Attachment `byte[]` data serializes as a base64 JSON string. Newtonsoft.Json naming follows the settings and contract resolver configured by the caller because this DTO declares only System.Text.Json attributes.

Optional recipient lists, `ReplyTo`, and `Attachments` remain null unless assigned. `To`, `Name`, `Address`, `Subject`, and `Body` are not initialized by the parameterless constructor even though their C# types are non-nullable; populate them before sending or serialization.

The DTO does not validate or normalize addresses, require recipients, sanitize HTML, encode plain text, infer MIME types, limit attachment size, or send the message. Treat untrusted HTML as unsafe until it has passed the application’s content policy, and enforce provider-specific recipient and attachment limits before dispatch.
