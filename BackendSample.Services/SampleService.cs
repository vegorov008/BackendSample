using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BackendSample.Services.Contracts;

namespace BackendSample.Services
{
    public class SampleService : ISampleService
    {
        public Task<int> DoBusiness(Guid entityId, int param, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task GetEntity(Guid entityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
