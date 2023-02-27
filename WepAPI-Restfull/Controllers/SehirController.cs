using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WepAPI_Restfull.Controllers
{
    public class SehirController : ApiController
    {
        private string[] sehirler =new string[]{ "Antalya", "Ankara", "Mardin<" };
    [HttpGet]
        public string[]  Get()
        {
            return sehirler;
                
                }
        public string Get(int id)
        {
            return sehirler[id];
        }

    }
}
