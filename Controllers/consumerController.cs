using Microsoft.AspNetCore.Mvc;

namespace Farmer_To_Customer.Controllers
{
    public class consumerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
