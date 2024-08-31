using Candidate_Skill_MVC_CORE_MasterDetails.Models;
using Microsoft.AspNetCore.Mvc;

namespace Candidate_Skill_MVC_CORE_MasterDetails.Controllers
{
    public class HomeController : Controller
    {
        private readonly CandidateDbContext _context;
        public HomeController(CandidateDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Aggrigate()
        {
            int TotalMarks = _context.Result.Where(x => x.CandidateId == 1).Count();
            ViewBag.totalMarks = TotalMarks;

            int total = (int)_context.Result.Where(x => x.CandidateId == 1).Sum(x => x.Marks);
            ViewBag.total = total;

            int max = (int)_context.Result.Where(x => x.CandidateId == 1).Max(x => x.Marks);
            ViewBag.max = max;

            int min = (int)_context.Result.Where(x => x.CandidateId == 1).Min(x => x.Marks);
            ViewBag.min = min;

            int avg = (int)_context.Result.Where(x => x.CandidateId == 1).Average(x => x.Marks);
            ViewBag.avg = avg;
            return View();
        }
    }
}
