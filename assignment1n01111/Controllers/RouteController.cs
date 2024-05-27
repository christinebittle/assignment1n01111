using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1n01111.Controllers
{
    public class RouteController : ApiController
    {
        // GET : api/Route/Method1 -> "method 1"
        [HttpGet]
        public string Method1()
        {

            return "method 1";
        }

        // GET : api/Route/Method2 -> "method 2"
        [HttpGet]
        public string Method2()
        {

            return "method 2";
        }

        // GET : api/Route/Method3/{id} -> "Method 3 has an input of {id}"
        [HttpGet]
        public string Method3(int id)
        {
            string message = "Method 3 has an input of ";
            message = message + id;
            return message;
        }




        /// <summary>
        /// Receives two inputs and outputs their value
        /// </summary>
        /// <param name="input1">the first input</param>
        /// <param name="input2">the second input</param>
        /// <returns>
        /// "input 1 is {input1} and input 2 is {input 2}"
        /// </returns>
        /// <example>
        /// GET : api/Route/Method4/{input1}/{input2} -> "input 1 is {input1} and input 2 is {input 2}"
        /// </example>
        /// <example>
        /// GET : api/Route/Method4/2/4 -> "input 1 is 2 and input 2 is 4"
        /// </example>
        [HttpGet]
        [Route("api/Route/Method4/{input1}/{input2}")]
        public string Method4(int input1, int input2)
        {
            string output = "input 1 is "+input1;
            output = output + " and input 2 is "+input2; 
            return output;
        }

        // POST : api/Route/Method5 -> "our POST request"
        [HttpPost]
        public string Method5()
        {

            return "our POST request";
        }
    }
}
