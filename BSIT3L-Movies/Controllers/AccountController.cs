using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
