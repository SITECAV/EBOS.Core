using System.Collections.ObjectModel;

namespace EBOS.Core.Mail.Dto;

public class MailMessageDto 
{ 
    public List<MailAddressDto> FromAddress { get; set; } 
    public List<MailAddressDto> ToAddress { get; set; } 
    public string Subject { get; set; } 
    public string Message { get; set; } 
    public string BodyType { get; set; } 
    public MailAttachmentDto? MailAttachment { get; set; } 
}