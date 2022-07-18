using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityApp.BLL.RequestViewModel;
using UniversityApp.BLL.Services;

namespace UniversityApp.API.Controllers
{
    [ApiController]
    [Route(template:"[controller]")]
    
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _deprtmentService;

        public DepartmentsController(IDepartmentService deprtmentService)
        {
            _deprtmentService = deprtmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _deprtmentService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Insert(DepartmentInsertRequestViewModel request)
        {
            return Ok(await _deprtmentService.InsertAsync(request));
        }
    }
}
