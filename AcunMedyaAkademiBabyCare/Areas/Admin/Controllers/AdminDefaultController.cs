using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiBabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
