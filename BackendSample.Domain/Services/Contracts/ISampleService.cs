using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BackendSample.Domain.Models;

namespace BackendSample.Domain.Services.Contracts
{
    public interface ISampleService
    {
        Task<bool> DoBusiness(Guid entityId, int param, CancellationToken cancellationToken);
        Task<SampleEntity> GetEntity(Guid entityId, CancellationToken cancellationToken);
    }
}
