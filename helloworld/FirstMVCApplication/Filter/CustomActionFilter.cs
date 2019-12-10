using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Filter
{
    public class CustomActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);   
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
           
            var valueObject = (ContentResult)filterContext.Result;
            filterContext.Result = new ContentResult()
            {
                Content = "sdgasdgsgadsfgasd "
            };
            base.OnResultExecuted(filterContext);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }
    }
}