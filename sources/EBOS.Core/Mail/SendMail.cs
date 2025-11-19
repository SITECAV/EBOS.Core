using EBOS.Core.Mail.Dto;
using MailKit.Net.Smtp;
using MimeKit;

namespace EBOS.Core.Mail;

public class SendMail : ISendMail
{
    public async Task SendAsync(MailMessageDto mailMessage, MailSettingsDto mailSettings)
    {
        if (!mailSettings.SendMail) return;
        var message = CreateMessage(mailMessage);
        await SendMessageAsync(mailSettings, message);
    }

    private static MimeMessage CreateMessage(MailMessageDto mailMessage)
    {
        var message = new MimeMessage();
        message.From.AddRange(mailMessage.FromAddress.Select(mailAddress => new MailboxAddress(mailAddress.Name, mailAddress.Address)));
        message.To.AddRange(mailMessage.ToAddress.Select(mailAddress => new MailboxAddress(mailAddress.Name, mailAddress.Address)));
        message.Subject = mailMessage.Subject;

        message.Body = new TextPart(mailMessage.BodyType)
        {
            Text = mailMessage.Message
        };

        if (mailMessage.MailAttachment != null)
        {
            var attachment = new MimePart(mailMessage.MailAttachment.MediaType)
            {
                FileName = mailMessage.MailAttachment.FileName,
                Content = new MimeContent(new MemoryStream(mailMessage.MailAttachment.Content)),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64
            };

            var multipart = new Multipart("mixed") {
                        message.Body,
                        attachment
                    };

            message.Body = multipart;
        }
        return message;
    }

    private static async Task SendMessageAsync(MailSettingsDto mailSettings, MimeMessage message)
    {
        using var client = new SmtpClient();
        await client.ConnectAsync(mailSettings.Server, mailSettings.Port, mailSettings.HasSSL);
        await client.AuthenticateAsync(mailSettings.MailUser, mailSettings.MailPassword);
        await client.SendAsync(message);
        await client.DisconnectAsync(true);
    }
}
