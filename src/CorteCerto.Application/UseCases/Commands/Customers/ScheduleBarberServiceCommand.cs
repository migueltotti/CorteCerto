using CorteCerto.Application.DTO;
using CorteCerto.Application.Requests;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.Customers;

public record ScheduleBarberServiceCommand(RegisterAppointmentRequest Request) : ICommand<Result<AppointmentDto>>;
