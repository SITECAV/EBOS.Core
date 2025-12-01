namespace EBOS.Core.Primitives.Interfaces;

public interface IUserInfo
{
    int Id { get; set; }
    string Username { get; set; }
    string Name { get; set; }
    int LanguageId { get; set; }
    string Email { get; set; }
    int ConnectionId { get; set; }
}
