using CorteCerto.App.Interfaces;
using CorteCerto.Application.DTO;

namespace CorteCerto.App.Services;

public class SessionService : ISessionService
{
    public bool IsAuthenticated => _customer is not null;
    private CustomerDto? _customer = null;

    public void ClearSession() => _customer = null;
    public void SetSession(CustomerDto customer) => _customer = customer;
    public string GetUserName() => _customer?.Name ?? "";
    public string GetUserEmail() => _customer?.Email ?? "";
    public CustomerDto? GetCurrentCustomer() => _customer;
}
