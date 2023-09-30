namespace Helios.Application.Services.Authentication;

public interface IAutenticatinService
{
   AuthenticationResult Login( string email, string password);
   AuthenticationResult Register(string firstName, string lastName, string email, string password);
}