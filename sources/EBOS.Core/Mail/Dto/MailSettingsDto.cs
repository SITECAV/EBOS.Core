namespace EBOS.Core.Mail.Dto;

public class MailSettingsDto 
{ 
    public string Server { get; set; } 
    public int Port { get; set; } 
    public string MailUser { get; set; } 
    public string MailPassword { get; set; } 
    public bool HasSSL { get; set; } 
    public bool SendMail { get; set; } 
}