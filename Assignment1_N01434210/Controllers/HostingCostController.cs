using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01434210.Controllers
{
    public class HostingCostController : ApiController
    {
        public IEnumerable<string> GET(int id) 
        {
            int fortnight = id / 14;
            double costPerNight = 5.50;
            double cost = fortnight * costPerNight;
            double baseCost = 5.50;
            double subtotal = cost + baseCost;
            double hst = subtotal * 0.13;
            double total = hst + subtotal;

            string subtotalLine = fortnight + " fortnights at " + costPerNight.ToString("C2") + "/FN = " +subtotal.ToString("C2") + " CAD";
            string hstLine = "HST 13% = $" + Math.Round(hst,2) + " CAD";
            string totalLine = "Total = $" + Math.Round(total,2) + " CAD";

            return new string[] { subtotalLine, hstLine, totalLine };
        }
            
    }
}
