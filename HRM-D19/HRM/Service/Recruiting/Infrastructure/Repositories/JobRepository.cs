using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class JobRepository : IJobRepository
    {
        private RecruitingDbContext _recruitingDbContext;
        public JobRepository(RecruitingDbContext recruitingDbContext)
        {
            _recruitingDbContext = recruitingDbContext;
        }
        public async Task<List<Job>> GetAllJobs()
        {
            var jobs = await _recruitingDbContext.Jobs.ToListAsync();
            return jobs;
        }

        public async Task<Job> GetJobById(int id)
        {
            var job = await _recruitingDbContext.Jobs.FirstOrDefaultAsync(j => j.Id == id);
            return job;
        }

        public async Task<List<Job>> GetJobsByDepartment(int id)
        {
            var jobs = await _recruitingDbContext.Jobs.ToListAsync();
            List<Job> jobsByDepartment = new List<Job>();
            foreach (var job in jobs)
            {
                if (job.Department.Id == id)
                {
                    jobsByDepartment.Add(job);
                }
            }
            return jobsByDepartment;
        }
    }
}
