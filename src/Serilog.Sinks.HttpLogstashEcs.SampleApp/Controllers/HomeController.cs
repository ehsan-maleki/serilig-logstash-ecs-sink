using System;
using System.Web.Mvc;

namespace Serilog.Sinks.HttpLogstashEcs.SampleApp.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            Log.Information("Salam Khubi?");
            Log.Debug("Injaeem");
            Log.Error(new Exception("asdfnadsf kjasdhvldhsvklahjsdv"), "terkidim");
            return Json("New logs created!");
        }
    }
}