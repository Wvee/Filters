using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Infrastructure
{
    public class DiagnosticsFilter : IAsyncResultFilter
    {
        private IFilterDiagnostics diagnostics;
        public DiagnosticsFilter(IFilterDiagnostics diag)
        {
            diagnostics = diag;
        }
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            await next();
            foreach (var message in diagnostics.Messages)
            {
                byte[] bytes = Encoding.ASCII.GetBytes($"<div>{message}</div>");
                await context.HttpContext.Response.Body.WriteAsync(bytes,0,bytes.Length);
            }
        }
    }
}
