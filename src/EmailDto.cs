using Soenneker.Enums.Email.Format;
using Soenneker.Enums.Email.Priority;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Soenneker.Dtos.Email.Attachment;

namespace Soenneker.Dtos.Email;

/// <summary>
/// A DTO type for email encapsulation
/// </summary>
public class EmailDto
{
    /// <summary>
    /// Recipient email addresses.
    /// </summary>
    [JsonPropertyName("to")]
    public List<string> To { get; set; } = null!;

    /// <summary>
    /// Carbon Copy recipients.
    /// </summary>
    [JsonPropertyName("cc")]
    public List<string>? Cc { get; set; }

    /// <summary>
    /// Blind Carbon Copy recipients.
    /// </summary>
    [JsonPropertyName("bcc")]
    public List<string>? Bcc { get; set; }

    /// <summary>
    /// Reply-To email address.
    /// </summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>
    /// Sender's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Sender's email address.
    /// </summary>
    [JsonPropertyName("address")]
    public string Address { get; set; } = null!;

    /// <summary>
    /// Email subject.
    /// </summary>
    [JsonPropertyName("subject")]
    public string Subject { get; set; } = null!;

    /// <summary>
    /// Email body content.
    /// </summary>
    [JsonPropertyName("body")]
    public string Body { get; set; } = null!;

    /// <summary>
    /// Specifies whether the email is in plain text or HTML format.
    /// </summary>
    [JsonPropertyName("format")]
    public EmailFormat Format { get; set; } = EmailFormat.Html;

    /// <summary>
    /// Attachments as byte arrays.
    /// </summary>
    [JsonPropertyName("attachments")]
    public List<EmailAttachmentDto>? Attachments { get; set; }

    /// <summary>
    /// Email priority (Low, Normal, High).
    /// </summary>
    [JsonPropertyName("priority")]
    public EmailPriority Priority { get; set; } = EmailPriority.Normal;
}