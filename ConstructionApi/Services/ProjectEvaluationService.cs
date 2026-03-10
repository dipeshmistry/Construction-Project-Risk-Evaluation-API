using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructionApi.Models;

namespace ConstructionApi.Services
{
    public class ProjectEvaluationService : IProjectEvaluationService
    {
        private readonly IExternalRiskService _externalService;
        private readonly ILogger<ProjectEvaluationService> _logger;

        public ProjectEvaluationService(
            IExternalRiskService externalService,
            ILogger<ProjectEvaluationService> logger)
        {
            _externalService = externalService;
            _logger = logger;
        }

        public async Task<ProjectProgressResponse> EvaluateAsync(ProjectProgressRequest request)
        {
            if (request.FloorsCompleted > request.TotalFloorsPlanned)
                throw new ArgumentException("Floors completed cannot exceed total floors planned.");

            if (request.AmountSpent > request.TotalBudget)
                throw new ArgumentException("Amount spent cannot exceed total budget.");

            await _externalService.ValidateProjectAsync(request.ProjectName);

            decimal completion =
                ((decimal)request.FloorsCompleted / request.TotalFloorsPlanned) * 100;

            decimal budgetUtilization =
                (request.AmountSpent / request.TotalBudget) * 100;

            string status;

            if (completion < 30 && budgetUtilization > 50)
                status = "Critical Delay";
            else if (completion >= budgetUtilization)
                status = "On Track";
            else if ((budgetUtilization - completion) > 15)
                status = "Over Budget Risk";
            else
                status = "Needs Monitoring";

            _logger.LogInformation("Project evaluated successfully");

            return new ProjectProgressResponse
            {
                CompletionPercentage = Math.Round(completion, 2),
                BudgetUtilizationPercentage = Math.Round(budgetUtilization, 2),
                ProjectHealthStatus = status,
                EvaluationDate = DateTime.UtcNow
            };
        }
    }
}