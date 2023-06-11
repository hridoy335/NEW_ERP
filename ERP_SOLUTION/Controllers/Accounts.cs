using Microsoft.AspNetCore.Mvc;

namespace ERP_SOLUTION.Controllers
{ 
    public class AccountsController : Controller 
    {
        public IActionResult Login() 
        {
            return View();
        }
    }
}
