using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Serilog.Sinks.HttpLogstashEcs.SampleApp
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .Enrich.WithProperty("ApplicationName", "Serilog.Sinks.LogstashHttp.ExampleApp")
                .WriteTo.Console()
                .WriteTo.HttpLogstashEcs("https://localhost:35000")
                .MinimumLevel.Debug()
                .CreateLogger();
        }
    }
}