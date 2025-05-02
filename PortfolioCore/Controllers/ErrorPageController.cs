using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult ErrorPage()
        {
            return View();
        }
    }
}