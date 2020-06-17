using Microsoft.AspNetCore.Mvc;

namespace PiggyvestCalculator.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}