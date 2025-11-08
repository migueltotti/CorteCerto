using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Infrastructure.Repositories
{
    public class PersonRepository(CorteCertoDbContext context) : BaseRepository<Person, Guid>(context), IPersonRepository
    {
    }
}
