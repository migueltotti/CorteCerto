using CorteCerto.App.Interfaces;
using CorteCerto.Application.DTO;

namespace CorteCerto.App.Services;

public class SessionService : ISessionService
{
    public bool IsAuthenticated => _customer is not null;
    private CustomerDto? _customer = null;
    private BarberDto? _barber = null;

    public string GetUserName() => _customer?.Name ?? "";
    public string GetUserEmail() => _customer?.Email ?? "";
    public CustomerDto? GetCurrentUser() => _customer;
    public bool CurrentUserHasBarberProfile() => _barber is not null;

    public void SetSession(CustomerDto customer, BarberDto? barber)
    {
        _customer = customer;
        _barber = barber;
    }

    public void ClearSession()
    {
        _customer = null;
        _barber = null;
    }
}
