using Microsoft.AspNetCore.Mvc;

namespace ERP_SOLUTION.Controllers
{
    public class Test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
