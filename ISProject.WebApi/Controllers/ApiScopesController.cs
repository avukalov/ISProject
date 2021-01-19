using IdentityServer4.EntityFramework.Mappers;
using IdentityServer4.Models;
using ISProject.Service.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISProject.WebApi.Controllers
{
    [Route("api/api-scopes")]
    [ApiController]
    public class ApiScopesController : ControllerBase
    {
        private readonly IApiScopeService _apiScopeService;

        public ApiScopesController(IApiScopeService apiScopeService)
        {
            _apiScopeService = apiScopeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _apiScopeService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetApiScopeById(string id)
        {
            var apiScope = await _apiScopeService.GetApiScopeByIdAsync(Int16.Parse(id));

            if (apiScope == null)
            {
                return NotFound();
            }

            return Ok(apiScope);
        }

        [HttpPost]
        public async Task<IActionResult> CreateApiScope([FromBody] ApiScope model)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }

            await _apiScopeService.AddApiScopeAsync(model);

            
            return Ok();
        }
    }
}
