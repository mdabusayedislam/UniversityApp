using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnversityApp.DLL.UOW
{
    public interface IUnitOfWork:IDisposable
    {
        Task<bool> Commit();
    }
}
