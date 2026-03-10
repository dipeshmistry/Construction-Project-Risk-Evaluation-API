using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructionApi.Models;

namespace ConstructionApi.Services
{
    public interface IProjectEvaluationService
    {
        Task<ProjectProgressResponse> EvaluateAsync(ProjectProgressRequest request);
    }
}