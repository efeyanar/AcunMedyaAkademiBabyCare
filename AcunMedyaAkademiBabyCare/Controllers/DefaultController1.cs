using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiBabyCare.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
