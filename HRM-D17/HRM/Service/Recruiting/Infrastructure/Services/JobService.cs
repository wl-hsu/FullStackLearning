using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
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
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public async Task<List<JobResponseModel>> GetAllJobs()
        {
            var jobs = await _jobRepository.GetAllJobs();
            var jobsResponseModel = new List<JobResponseModel>();
            foreach (var job in jobs)
            {
                jobsResponseModel.Add(new JobResponseModel()
                {
                    Id = job.Id,
                    Description = job.Description,
                    Title = job.Title,
                    StarDate = job.StartDate.GetValueOrDefault(),
                    NumberOfPositions = job.NumberOfPositions,
                }) ;
            }
            return jobsResponseModel;
        }

        public async Task< JobResponseModel> GetJobsById(int id)
        {
            var job = await _jobRepository.GetJobById(id);
            var jobsResponseModel = new JobResponseModel
            {
                Id = job.Id,
                Description = job.Description,
                Title = job.Title,
                StarDate = job.StartDate.GetValueOrDefault(),
            };
            return jobsResponseModel;
        }
    }
}
