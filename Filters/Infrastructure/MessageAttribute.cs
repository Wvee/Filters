using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Infrastructure
{
    public class MessageAttribute:ResultFilterAttribute
    {
        private string message;
        public MessageAttribute(string mes)
        {
            message = mes;
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            WriteMessage(context,$"<div>Befor Result:{message}</div>");
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            WriteMessage(context,$"<div>After Result:{message}</div>");
        }
        public void WriteMessage(FilterContext context,string message)
        {
            byte[] bytes = Encoding.ASCII.GetBytes($"<div>{message}</div>");
            context.HttpContext.Response.Body.Write(bytes,0,bytes.Length);

        }
    }
}
