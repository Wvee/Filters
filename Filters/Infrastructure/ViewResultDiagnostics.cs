using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Infrastructure
{
    public class ViewResultDiagnostics : IActionFilter
    {
        private IFilterDiagnostics diagnostics;
        public ViewResultDiagnostics(IFilterDiagnostics diag)
        {
            diagnostics = diag;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //do nothing
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            ViewResult vr;
            if ((vr=context.Result as ViewResult)!=null)
            {
                diagnostics.AddMessage($"ViewName:{vr.ViewName}");
                diagnostics.AddMessage($"ModelType:{vr.ViewData.Model.GetType().Name}");
            }
        }
    }
}
