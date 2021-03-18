using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerAndHangfireAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwaggerTestController : ControllerBase
    {
        /// <summary>
        /// Get method text
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Get()
        {
            return "get action";
        }

        /// <summary>
        /// update method text
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public string Update()
        {
            return "update action";
        }

        /// <summary>
        /// remove method text
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public string Remove()
        {
            return "remove action";
        }
    }
}
