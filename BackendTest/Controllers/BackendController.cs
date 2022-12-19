using BackendTest.Controllers.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace BackendTest.Controllers
{
    // Specify Controller type
    [ApiController]
    // Specify the route for its execution
    [Route("backend")]
    public class BackendController : ControllerBase
    {
        // Specify the verb to use
        [HttpPost]
        // Specify the route for its execution
        [Route("remove-duplicates")]
        //We create a function with the type of the corresponding model in this case BackEnd
        public dynamic save(Backend backend)
        {
            //Create an array type variable
            //Use the Distinc property to remove duplicates
            //Then we convert it to an Array
            //And finally we store it in the variable of type Array
            string[] WithoutRepeated = backend.repeatedValues.Distinct().ToArray();
            //To finish we return the variable
            return new
            {
                //Through the uniques key
                uniques = WithoutRepeated
            };
        }
        // Specify the verb to use
        [HttpPost]
        // Specify the route for its execution
        [Route("organize")]
        //We create a function with the type of the corresponding model in this case Organize
        public dynamic order(Organize organize)
        {
            //To finish we return the variable
            return new
            {
                organize
            };

        }

        
    }
}
