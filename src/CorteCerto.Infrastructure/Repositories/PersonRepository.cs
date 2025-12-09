using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Infrastructure.Repositories
{
    public class PersonRepository(CorteCertoDbContext context) : BaseRepository<Person, Guid>(context), IPersonRepository
    {
        public Task<Person?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            return context.People
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Email == email, cancellationToken);
        }
    }
}
