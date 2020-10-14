using ExtCore.Data.Abstractions;
using Extension.Data.Abstractions.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly IStorage storage;
        public PostController(IStorage storage)
        {
            this.storage = storage;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var posts = this.storage.GetRepository<IPostRepository>().All();
            return StatusCode(200, new { Flag = true, Data = posts });
        }
    }
}
