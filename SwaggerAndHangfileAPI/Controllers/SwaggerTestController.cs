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
            string result = "get action";
            return result;
        }

        /// <summary>
        /// update method text
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public string Update()
        {
            string result = "update action";
            return result;
        }

        /// <summary>
        /// remove method text
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public string Remove()
        {
            string result = "remove action";
            return result;
        }
    }
}
