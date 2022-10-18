using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace BackendSample.API.Queries
{
    public class SampleQuery : IRequest<SampleQueryResult>
    {
        public Guid Id { get; set; }
    }
}
