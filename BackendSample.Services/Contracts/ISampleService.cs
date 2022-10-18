using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackendSample.Services.Contracts
{
    public interface ISampleService
    {
        Task<int> DoBusiness(Guid entityId, int param, CancellationToken cancellationToken);
        Task GetEntity(Guid entityId, CancellationToken cancellationToken);
    }
}
