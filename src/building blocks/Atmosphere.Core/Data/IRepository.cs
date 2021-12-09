using Atmosphere.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atmosphere.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
