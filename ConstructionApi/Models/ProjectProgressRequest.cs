using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionApi.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ProjectProgressRequest
    {
        [Required]
        public required string ProjectName { get; set; }

        [Required]
        public required string SiteEngineerName { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int TotalFloorsPlanned { get; set; }

        [Required]
        public int FloorsCompleted { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal TotalBudget { get; set; }

        [Required]
        public decimal AmountSpent { get; set; }
    }
}