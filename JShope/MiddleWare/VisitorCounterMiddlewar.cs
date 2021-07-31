using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JShope.Services.Interface;
using Microsoft.AspNetCore.Http;

namespace JShope.MiddleWare
{
    public class VisitorCounterMiddleware
    {
     
        private readonly RequestDelegate _requestDelegate;

        public VisitorCounterMiddleware( RequestDelegate requestDelegate)
        {
           
            _requestDelegate = requestDelegate;
        }


       

        

        public async Task Invoke(HttpContext context)
        {
            string visitorId = context.Connection.RemoteIpAddress.ToString();

            var ip = context.Connection.Id;
            await _requestDelegate(context);
        }
    }
}
