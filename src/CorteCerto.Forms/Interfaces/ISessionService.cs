using CorteCerto.Application.DTO;

namespace CorteCerto.App.Interfaces;

public interface ISessionService
{
    bool IsAuthenticated { get; }

    void SetSession(CustomerDto customer, BarberDto? barber);
    void ClearSession();
    string GetUserName();
    string GetUserEmail();
    CustomerDto? GetCurrentUser();
    bool CurrentUserHasBarberProfile();
}
