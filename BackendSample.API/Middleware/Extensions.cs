using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace BackendSample.API.Middleware
{
    public static class Extensions
    {
        public static IApplicationBuilder UseSampleMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SampleMiddleware>();
        }
    }
}
