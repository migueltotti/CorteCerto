using CorteCerto.Application.DTO;

namespace CorteCerto.App.Interfaces;

internal interface ISessionService
{
    bool IsAuthenticated { get; }

    void SetSession(LoginDto result);
    void ClearSession();
}
