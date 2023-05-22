using Microsoft.AspNetCore.Mvc;

namespace ERP_SOLUTION.Controllers
{
    public class Accounts : Controller
    {
        public IActionResult Login() 
        {
            return View();
        }
    }
}
