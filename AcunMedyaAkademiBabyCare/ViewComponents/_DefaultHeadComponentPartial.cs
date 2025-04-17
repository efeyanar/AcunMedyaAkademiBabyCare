using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiBabyCare.ViewComponents
{
    public class _DefaultHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
