using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace BackendSample.API.Commands
{
    public class SampleCommand : IRequest<bool> 
    {
        public Guid Id { get; set; }
        public int SampleParam { get; set; }
    }
}
