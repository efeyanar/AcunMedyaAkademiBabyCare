using AcunMedyaAkademiBabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiBabyCare.ViewComponents
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        private readonly BabyCareContext _context;

        public _DefaultAboutComponentPartial(BabyCareContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
    }
}
