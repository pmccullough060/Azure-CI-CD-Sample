using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PeterAzureConfig.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MainController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            //configuring the blob storage logging.

            Trace.WriteLine("Http Get Request Triggered");
            Trace.TraceInformation("Http Get Request Triggered");
            Trace.TraceError("Http Get Request Triggered");
            Trace.TraceWarning("Http Get Request Triggered");

            return new OkObjectResult("Hello");
        }

        [HttpGet("{input}")] //passes this in as an argument 
        public IActionResult Get(string input)
        {
            //configuring the blob storage logging.

            Trace.WriteLine($"Http Get Request Triggered {input}");
            Trace.TraceInformation($"Http Get Request Triggered {input}");
            Trace.TraceError($"Http Get Request Triggered {input}");
            Trace.TraceWarning($"Http Get Request Triggered {input}");

            return new OkObjectResult(input);
        }
    }
}
