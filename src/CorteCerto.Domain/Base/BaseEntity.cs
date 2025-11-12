using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Base;

public abstract class BaseEntity<TId> : IBaseEntity
{
    public TId Id { get; private set; }

    protected BaseEntity(TId id) => Id = id;
    protected BaseEntity() { }
}
