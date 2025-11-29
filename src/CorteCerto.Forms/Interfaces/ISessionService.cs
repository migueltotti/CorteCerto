using CorteCerto.Application.DTO;

namespace CorteCerto.App.Interfaces;

public interface ISessionService
{
    bool IsAuthenticated { get; }

    void SetSession(CustomerDto customer);
    void ClearSession();
    string GetUserName();
    string GetUserEmail();
}
