using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class JobsController : Controller
    {
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult Details(int id)
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create()
        //{
        //    return View();
        //}

        private IJobService _jobService;
        public JobsController(IJobService jobService)
        {
            _jobService = jobService;

        }
        public async Task< IActionResult> Index()
        {
            ViewBag.PageTitle = "Showing jobs";
            var jobs = await _jobService.GetAllJobs();
            return View(jobs);
        }

        public IActionResult GetJobsByDepartment(int id, int pageSize = 30, int pageNumber = 1)
        {
            var departmentJobs = _jobService.GetJobsByDepartment(id);

            var paginatedResult = new PaginatedResultSet<Job>
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                //TotalItemCount = departmentJobs.Count(),
                //Items = departmentJobs.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
            };

            return View(paginatedResult);
        }

        public async Task<IActionResult> Details(int id)
        {

            var jobs = _jobService.GetJobsById(id);
            return View(jobs);
        }


        public IActionResult Create()
        {
            return View();
        }

    }
}





/*
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
            return View(jobs);
        }

        public IActionResult Details(int id) { 

            var jobs = _jobService.GetJobsById(id);
            return View();
        }
    }
}
 
 */