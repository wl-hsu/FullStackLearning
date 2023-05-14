using ApplicationCore.Contracts.Services;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class Jobs : Controller
    {
        private IJobService _jobService;
        public Jobs(IJobService jobService)
        {
            _jobService = jobService;

        }
        public IActionResult Index()
        {
            var jobs = _jobService.GetAllJobs();
            return View();
        }

        public IActionResult Details(int id) { 

            var jobs = _jobService.GetJobsById(id);
            return View();
        }
    }
}
