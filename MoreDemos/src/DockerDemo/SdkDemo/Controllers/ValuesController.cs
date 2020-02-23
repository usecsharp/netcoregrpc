﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SdkDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" , "sdk" };
        }      
    }
}
