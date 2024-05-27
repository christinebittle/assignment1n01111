using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1n01111.Controllers
{
    public class ExampleController : ApiController
    {

        //we have the ability to listen for http requests
        //and provide responses to those requests


        //GET : localhost:xx/api/Example -> "A response to a GET request"
        public string Get()
        {
            string response = "A response to a GET request";

            return response;
        }


        /// <summary>
        /// Receives a number and returns a message indicating what number was entered.
        /// </summary>
        /// <param name="id">the number to enter</param>
        /// <returns>
        /// "You entered the number {id}"
        /// </returns>
        /// <example>
        /// GET : localhost:xx/api/Example/{id} -> "You entered the number {id}"
        //GET : localhost:xx/api/Example/3 -> "You entered the number 3"
        //GET : localhost:xx/api/Example/10 -> "You entered the number 10"
        //GET : localhost:xx/api/Example/-10 -> "You entered the number -10"
        /// </example>
        public string Get(int id)
        {
            string message =  "You entered the number ";
            message = message + id;
            return message;
        }



        /// <summary>
        /// This method listens for a post request and provides a string response
        /// </summary>
        /// <returns>
        /// "A response to a POST request"
        /// </returns>
        /// <example>
        /// POST : localhost:xx/api/Example -> "A response to a POST request"
        /// curl -d "" http://localhost:57149/api/example
        /// </example>
        public string Post()
        {
            string response = "A response to a POST request";
            return response;
        }

    }
}
