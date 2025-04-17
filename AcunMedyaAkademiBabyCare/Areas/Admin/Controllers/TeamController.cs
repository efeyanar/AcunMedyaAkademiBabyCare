using AcunMedyaAkademiBabyCare.Context;
using AcunMedyaAkademiBabyCare.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaAkademiBabyCare.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        private readonly BabyCareContext _context;

        public TeamController(BabyCareContext context)
        {
            _context = context;
        }

        public IActionResult TeamList()
        {
            var values = _context.Teams.Include(x=>x.Branch).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateTeam()
        {
            List<SelectListItem> values = (from x in _context.Branches.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.BranchName,
                                               Value = x.BranchId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult CreateTeam(Team team)
        {
            //Fast Fail
            if (!ModelState.IsValid)//kurallara uymuyorsa
            { 
                return View(team);
            }
            _context.Teams.Add(team);
            _context.SaveChanges();
            return RedirectToAction("TeamList");
        }
        public IActionResult DeleteTeam(int id)
        {
            var value = _context.Teams.Find(id);
            _context.Teams.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("TeamList");
        }
        [HttpGet]
        public IActionResult UpdateTeam(int id)
        {

            var values = _context.Teams.Find(id);
            List<SelectListItem> values1 = (from x in _context.Branches.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.BranchName,
                                                Value = x.BranchId.ToString()
                                            }).ToList();
            ViewBag.v = values1;
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateTeam(Team team)
        {
            var value = _context.Teams.Update(team);
            _context.SaveChanges();
            return RedirectToAction("TeamList");
        }
    }
}
