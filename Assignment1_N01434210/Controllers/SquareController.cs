using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01434210.Controllers
{
    public class SquareController : ApiController
    {/// <summary>
     /// This method returns one value when receiving GET request
     /// <example>GET api/Square/{id}</example>
     /// </summary>
     /// <param name="id"></param>
     /// <returns>(id*id)</returns>
        
        public int GET(int id)
        {
            return  (id*id);
        }
    }
}
