using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01434210.Controllers
{
    public class GreetingController : ApiController
    {/// <summary>
     /// This method returns one string when receiving GET request
     /// <example>GET api/Greeting/{id}</example>
     /// </summary>
     /// <param name="id"></param>
     /// <returns>"Greeting to {id} people"</returns>

        public string GET(int id)
        {
            return "Greetings to " + id + " people!";
        }
        /// <summary>
        /// This method returns one string when receiving POST request
        /// <example>GET api/Greeting</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>"Hello World!"</returns>

        public string POST()
        {
            return "Hello World!";
        }
    }
}
