using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiBabyCare.ViewComponents
{
    public class _DefaultNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
