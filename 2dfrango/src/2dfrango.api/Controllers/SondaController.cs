using Microsoft.AspNetCore.Mvc;
using System;

namespace _2dfrango.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SondaController : ControllerBase
    {
        [HttpGet]
        public string Sonda()
        {
            return new Random().Next(1000, 10000).ToString();
        }
    }
}