using AcunMedyaAkademiBabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiBabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly BabyCareContext _context;

        public DashboardController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.personelsayisi = _context.Teams.ToList().Count();
            return View();
        }
    }
}
