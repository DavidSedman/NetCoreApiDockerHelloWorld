using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NetCoreApiDockerHelloWorld.Controllers
{
    ///<summary>
    /// Values Controller
    ///</summary>
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        
        private readonly ILogger _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger"></param>
        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var result = new string[] { "Hello", "World" };

            _logger.LogInformation("{result}");
            return result;
        } 

        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            _logger.LogInformation($"Getting item {id}");
            
            if (id == 0)
            {
                _logger.LogWarning($"GetById({id}) NOT FOUND");
                return $"GetById({id}) NOT FOUND";
            }
            
            var result = $"Hello, Number {id}!";
            return result;
        }
    }
}
