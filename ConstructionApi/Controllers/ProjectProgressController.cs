using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructionApi.Models;
using ConstructionApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionApi.Controllers
{
    [ApiController]
    [Route("api/project")]
    public class ProjectProgressController : ControllerBase
    {
        private readonly IProjectEvaluationService _service;

        public ProjectProgressController(IProjectEvaluationService service)
        {
            _service = service;
        }

        [HttpPost("progress")]
        public async Task<IActionResult> Evaluate(ProjectProgressRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _service.EvaluateAsync(request);

            return Ok(result);
        }
    }
}