using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomFilter.CustomFilter
{
    public class SwadhinFilter:ActionFilterAttribute

    {
      

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("OnActionExecuted", filterContext.RouteData);
        }
        //
        // Summary:
        //     Called by the ASP.NET MVC framework before the action method executes.
        //
        // Parameters:
        //   filterContext:
        //     The filter context.
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActionExecuting", filterContext.RouteData);
        }
        //
        // Summary:
        //     Called by the ASP.NET MVC framework after the action result executes.
        //
        // Parameters:
        //   filterContext:
        //     The filter context.
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("OnResultExecuted", filterContext.RouteData);
        }
        //
        // Summary:
        //     Called by the ASP.NET MVC framework before the action result executes.
        //
        // Parameters:
        //   filterContext:
        //     The filter context.
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log("OnResultExecuting", filterContext.RouteData);
        }
        private FileStream FileOpen(string v, FileMode append, FileAccess write)
        {
            throw new NotImplementedException();
        }
        public void Log( String method, RouteData routeData) {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = string.Format("{0} = {1} --> {2}", DateTime.Now,  method, controllerName, actionName);
            FileStream filestream = File.Open("c:\\Logs\\demo.txt", FileMode.Append, FileAccess.Write);
            StreamWriter fileWriter = new StreamWriter(filestream);
            fileWriter.WriteLine(message);
            fileWriter.Flush();
            fileWriter.Close();

        }
    }

    }
