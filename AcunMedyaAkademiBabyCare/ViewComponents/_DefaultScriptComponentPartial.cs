using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiBabyCare.ViewComponents
{
    public class _DefaultScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
