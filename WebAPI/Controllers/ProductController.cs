using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class ProductController : ControllerBase
    {
        [HttpGet("{id}")]
        [MapToApiVersion("1.0")]
        public IActionResult GetProduct(int id)
        {
            var response = new Product()
            {
                ID = id,
                Name = "P1"
            };

            return Ok(response);
        }


        [HttpGet("{id}")]
        [MapToApiVersion("2.0")]
        public IActionResult GetProductV1(int id)
        {
            var response = new Product()
            {
                ID = id,
                Name = "P1 - Version 1"
            };

            return Ok(response);
        }
    }
}
