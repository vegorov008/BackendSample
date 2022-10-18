using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BackendSample.API.Middleware
{
    public class SampleMiddleware
    {
        private readonly RequestDelegate _next;

        public SampleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Do middleware job

            await _next(context);
        }
    }
}
