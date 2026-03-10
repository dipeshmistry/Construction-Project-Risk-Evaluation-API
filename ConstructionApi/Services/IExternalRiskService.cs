using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionApi.Services
{
    public interface IExternalRiskService
    {
        Task<bool> ValidateProjectAsync(string projectName);
    }
}