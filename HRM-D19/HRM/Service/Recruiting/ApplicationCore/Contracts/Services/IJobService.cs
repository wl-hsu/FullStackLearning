﻿using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IJobService
    {
        Task<List<JobResponseModel>> GetAllJobs();
        Task<JobResponseModel> GetJobsById(int id);

        Task<List<JobResponseModel>> GetJobsByDepartment(int id);
    }
}
