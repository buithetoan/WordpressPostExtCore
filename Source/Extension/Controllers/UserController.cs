using Microsoft.AspNetCore.Mvc;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Identity;
using Extension.Data.Entities.Models;
using System.Threading.Tasks;
using System;

namespace Extension.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IStorage storage;
        private readonly UserManager<ApplicationUser> userManager;
        public UserController(IStorage storage, UserManager<ApplicationUser> userManager)
        {
            this.storage = storage;
            this.userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //ApplicationUser applicationUser = new ApplicationUser();

            //applicationUser.UserName = "Administrator";
            //try
            //{
            //    var user = await userManager.CreateAsync(applicationUser);
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}

            //var employees = this.storage.GetRepository<IEmployeeRepository>().All();
            return StatusCode(200, new { Flag = true, Data = "Hello world" });
        }
    }
}
