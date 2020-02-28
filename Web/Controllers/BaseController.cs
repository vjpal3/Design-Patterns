using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logger;

namespace Web.Controllers
{
    public class BaseController : Controller
    {
        private ILog iLog;
        
        public BaseController()
        {
            iLog = Log.GetInstance;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            iLog.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
    }
}