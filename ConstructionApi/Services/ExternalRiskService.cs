using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionApi.Services
{
    public class ExternalRiskService : IExternalRiskService
    {
        public async Task<bool> ValidateProjectAsync(string projectName)
        {
            await Task.Delay(500); // simulate external API call
            return true;
        }
    }
}