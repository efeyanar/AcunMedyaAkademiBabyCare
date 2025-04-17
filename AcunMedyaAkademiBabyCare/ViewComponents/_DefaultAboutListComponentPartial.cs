using AcunMedyaAkademiBabyCare.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiBabyCare.ViewComponents
{
    public class _DefaultAboutListComponentPartial:ViewComponent
    {
        private readonly BabyCareContext _context;

        public _DefaultAboutListComponentPartial(BabyCareContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.AboutLists.ToList();
            return View(values);
        }
    }
}
