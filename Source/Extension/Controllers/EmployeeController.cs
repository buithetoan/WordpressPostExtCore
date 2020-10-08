using Microsoft.AspNetCore.Mvc;
using ExtCore.Data.Abstractions;
using Extension.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Extension.Data.Abstractions.Interfaces;
using Extension.Data.Entities.ViewModels;

namespace Extension.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private IStorage storage;
        public EmployeeController(IStorage storage)
        {
            this.storage = storage;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var employees = this.storage.GetRepository<IEmployeeRepository>().All();
            return StatusCode(200, new { Flag = true, Data = employees});
        }
    }
}
