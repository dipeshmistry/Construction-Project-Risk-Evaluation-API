using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionApi.Models
{
    public class ProjectProgressResponse
    {
        public decimal CompletionPercentage { get; set; }

        public decimal BudgetUtilizationPercentage { get; set; }

        public required string ProjectHealthStatus { get; set; }

        public DateTime EvaluationDate { get; set; }
    }
}