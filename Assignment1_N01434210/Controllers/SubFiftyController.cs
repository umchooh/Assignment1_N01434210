using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01434210.Controllers
{
    public class SubFiftyController : ApiController
    {
        //GET/api/SubFifty/40--->-10
        public int GET(int id)
        {
            return (id - 50);
        }
    }
}    
