using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BackendSample.Domain.Models;
using BackendSample.Domain.Services.Contracts;

namespace BackendSample.Domain.Services.Implementations
{
    public class SampleService : ISampleService
    {
        public Task<bool> DoBusiness(Guid entityId, int param, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<SampleEntity> GetEntity(Guid entityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
