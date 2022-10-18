using System.Threading;
using System.Threading.Tasks;
using BackendSample.API.Commands;
using BackendSample.Domain.Services.Contracts;
using MediatR;

namespace BackendSample.API.Handlers
{
    public class SampleCommandHandler : IRequestHandler<SampleCommand, bool>
    {
        ISampleService _sampleService;

        public SampleCommandHandler(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }

        public async Task<bool> Handle(SampleCommand request, CancellationToken cancellationToken)
        {
            return await _sampleService.DoBusiness(request.Id, request.SampleParam, cancellationToken);
        }
    }
}
