using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Atmosphere.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
