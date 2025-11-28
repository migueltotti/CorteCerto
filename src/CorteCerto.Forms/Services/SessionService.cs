using CorteCerto.App.Interfaces;
using CorteCerto.Application.DTO;

namespace CorteCerto.App.Services;

public class SessionService : ISessionService
{
    public bool IsAuthenticated => !string.IsNullOrEmpty(AccessToken);

    private string AccessToken = string.Empty;

    public void ClearSession()
    {
        AccessToken = string.Empty;
    }

    public void SetSession(LoginDto result)
    {
        AccessToken = result.AccessToken;
    }
}
