using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BackendSample.API.Queries;
using BackendSample.Domain.Services.Contracts;
using MediatR;

namespace BackendSample.API.Handlers
{
    public class SampleQueryHandler : IRequestHandler<SampleQuery, SampleQueryResult>
    {
        ISampleService _sampleService;

        public SampleQueryHandler(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }

        public async Task<SampleQueryResult> Handle(SampleQuery request, CancellationToken cancellationToken)
        {
            var result = await _sampleService.GetEntity(request.Id, cancellationToken);

            return new SampleQueryResult()
            {
                Id = result.Id,
                SampleParam = result.SampleParam
            };
        }
    }
}
