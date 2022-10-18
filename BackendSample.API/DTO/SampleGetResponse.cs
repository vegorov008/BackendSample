using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendSample.API.DTO
{
    public record SampleGetResponse
    {
        public Guid Id { get; init; }
        public int SampleParam { get; init; }
    }
}
