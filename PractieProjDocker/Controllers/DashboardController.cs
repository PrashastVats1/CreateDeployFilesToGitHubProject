using Microsoft.AspNetCore.Mvc;

namespace PractieProjDocker.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
