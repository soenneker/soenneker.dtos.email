[![](https://img.shields.io/nuget/v/soenneker.dtos.email.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.email/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.email/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.email/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.email.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.email/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.email/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.email/actions/workflows/codeql.yml)

# Soenneker.Dtos.Email

A DTO type for email encapsulation.

## Install

```bash
dotnet add package Soenneker.Dtos.Email
```

## What you get

- `EmailDto` — A DTO type for email encapsulation.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `EmailDto.To` | Recipient email addresses. | Recipient email addresses. |
| `EmailDto.Cc` | Carbon Copy recipients. | Carbon Copy recipients. |
| `EmailDto.Bcc` | Blind Carbon Copy recipients. | Blind Carbon Copy recipients. |
| `EmailDto.ReplyTo` | Reply-To email address. | Reply-To email address. |
| `EmailDto.Name` | Sender's name. | Sender's name. |
| `EmailDto.Address` | Sender's email address. | Sender's email address. |
| `EmailDto.Subject` | Email subject. | Email subject. |
| `EmailDto.Body` | Email body content. | Email body content. |
| `EmailDto.Format` | Specifies whether the email is in plain text or HTML format. | Specifies whether the email is in plain text or HTML format. |
| `EmailDto.Attachments` | Attachments as byte arrays. | Attachments as byte arrays. |
| `EmailDto.Priority` | Email priority (Low, Normal, High). | Email priority (Low, Normal, High). |
