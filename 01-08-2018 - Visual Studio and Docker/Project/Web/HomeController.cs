using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public string Trigger()
        {
          var client = new Service1Client(Service1Client.EndpointConfiguration.NetTcpBinding_IService1);
          var result = client.HelloAsync(null).Result;
          return "From Service1Client: " + result;
        }
    }
}
