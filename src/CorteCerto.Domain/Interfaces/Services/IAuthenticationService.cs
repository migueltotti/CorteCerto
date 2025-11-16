using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Responses;

namespace CorteCerto.Domain.Interfaces.Services;

public interface IAuthenticationService
{
    Result<Token> Authenticate(Person person, string password);
}
