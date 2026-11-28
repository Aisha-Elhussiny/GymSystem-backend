using GymSystem_backend.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymSystem_backend.Controllers
{
    public class PlanController : Controller
    {
        private GymDbContext context = new GymDbContext();
        public async Task<IActionResult> Index()
        {
            var plans = await context.Plans.ToListAsync();
            return View(plans);
        }
    }
}
