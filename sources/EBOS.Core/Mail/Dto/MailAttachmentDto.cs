namespace EBOS.Core.Mail.Dto;

public class MailAttachmentDto 
{ 
    public string MediaType { get; set; } 
    public byte[] Content { get; set; } 
    public string FileName { get; set; } 
}