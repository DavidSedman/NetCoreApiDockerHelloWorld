using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreApiDockerHelloWorld.Controllers
{
    ///<summary>
    /// Values Controller
    ///</summary>
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        ///<summary>
        /// Get All
        ///</summary>
        /// <param name="id"></param>
        [HttpGet]
        public IEnumerable<string> Get() => new string[] { "Hello", "World" };

        ///<summary>
        /// Get By Id
        ///</summary>
        /// <param name="id"></param>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var result = $"Hello, Number !";//{id}
            return result;
        }
    }
}
