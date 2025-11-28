using CorteCerto.Application.DTO;

namespace CorteCerto.App.Interfaces;

public interface ISessionService
{
    bool IsAuthenticated { get; }

    void SetSession(LoginDto result);
    void ClearSession();
}
