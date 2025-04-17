using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiBabyCare.Areas.Admin.ViewComponents
{
    public class _AdminDefaultSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
