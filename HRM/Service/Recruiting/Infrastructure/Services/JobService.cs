using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class JobService : IJobService
    {
        public List<JobResponseModel> GetAllJobs()
        {
            var jobs = new List<JobResponseModel>()
            {
                new JobResponseModel{Id = 1, Title = "example", Description = "Need example"},
                new JobResponseModel{Id = 2, Title = "example2", Description = "Need example2"},
                new JobResponseModel{Id = 3, Title = "example3", Description = "Need example3"},
                new JobResponseModel{Id = 4, Title = "example4", Description = "Need example4"}
            };
            return jobs;
        }

        public JobResponseModel GetJobsById(int id)
        {
            return new JobResponseModel { Id = 4, Title = "example4", Description = "Need example4" };

        }
    }
}
