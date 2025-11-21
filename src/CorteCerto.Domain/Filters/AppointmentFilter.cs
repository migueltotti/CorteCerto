using CorteCerto.Domain.Enums;

namespace CorteCerto.Domain.Filters;

public class AppointmentFilter
{
    public Guid? AppointmentId { get; private set; }
    public Guid? CustomerId { get; private set; }
    public Guid? BarberId { get; private set; }
    public int? ServiceId { get; private set; }
    public string? CustomerName { get; private set; }
    public string? BarberName { get; private set; }
    public string? ServiceName { get; private set; }
    public AppointmentStatus? AppointmentStatus { get; private set; }
    public DateTime? InitialDate { get; private set; }
    public DateTime? FinalDate { get; private set; }
    public int PageSize { get; set; } = 50;
    public int PageNumber { get; set; } = 1;

    private AppointmentFilter()
    {
    }

    public class Builder
    {
        private readonly AppointmentFilter _filter = new();

        public Builder() { }

        public Builder WithPagination(int PageSize, int PageNumber)
        {
            _filter.PageSize = PageSize;
            _filter.PageNumber = PageNumber;
            return this;
        }
        public Builder WithAppointmentId(Guid? id) { _filter.AppointmentId = id; return this; }
        public Builder WithCustomerId(Guid? customerId) { _filter.CustomerId = customerId; return this; }
        public Builder WithBarberId(Guid? barberId) { _filter.BarberId = barberId; return this; }
        public Builder WithServiceId(int? serviceId) { _filter.ServiceId = serviceId; return this; }
        public Builder WithCustomerName(string? customerName) { _filter.CustomerName = customerName; return this; }
        public Builder WithBarberName(string? barberName) { _filter.BarberName = barberName; return this; }
        public Builder WithServiceName(string? serviceName) { _filter.ServiceName = serviceName; return this; }
        public Builder WithAppointmentStatus(AppointmentStatus? status) { _filter.AppointmentStatus = status; return this; }
        public Builder WithDate(DateTime? initial, DateTime? final) 
        { 
            _filter.InitialDate = initial; 
            _filter.FinalDate = final; 
            return this; 
        }

        public AppointmentFilter Build()
        {
            return _filter;
        }
    }
}
