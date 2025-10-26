using CorteCerto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Entities;

public class Appointment : BaseEntity<int>
{
    public DateTime Date { get; private set; }
    public AppointmentStatus Status { get; private set; }
    public TimeSpan ResponseDeadline { get; private set; }
    public Customer Customer { get; private set; }
    public Barber Barber { get; private set; }
    public Service Service { get; private set; }
    
    private Appointment()
    {
    }

    public Appointment(int id, DateTime date, TimeSpan responseDeadline, Customer customer, Barber barber, Service service) : base(id)
    {
        // TODO: Inserir validação de Cliente não pode ser o Barbeiro
        // TODO: Inserir validação de Data não pode ser menor que a data atual
        // TODO: Inserir validação de Service deve pertencer ao Barbeiro
        Date = date;
        Status = AppointmentStatus.WaitingForAprovement;
        ResponseDeadline = responseDeadline;
        Customer = customer;
        Barber = barber;
        Service = service;
    }
}
