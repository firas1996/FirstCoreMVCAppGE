using Microsoft.AspNetCore.Mvc;

namespace FirstCoreMVCAppGEG2.Controllers
{
    public class TestController : Controller
    {
        public string Welcome()
        {
            return "Welcome to my First ASP.NET Core MVC Application";
        }
        public IActionResult WelcomeX(string x)
        {
            string msg ="WelcomeX to my First ASP.NET Core MVC Application";
            if(x != null)
            {
                if (x.Trim().Length > 0)
                {
                    msg = x + ", " + msg;
                }
            }
            ViewBag.Msg = msg;
            return View();
        }
        public IActionResult Max(int v1, int v2)
        {
            ViewBag.Max = Math.Max(v1, v2);
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
