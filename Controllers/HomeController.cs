using Microsoft.AspNetCore.Mvc;
using PersonalExampleWebPage.Models;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Net.Http;
using Newtonsoft.Json;

namespace PersonalExampleWebPage.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

#pragma warning disable CA1416 // Validate platform compatibility
            string _string = WindowsIdentity.GetCurrent().Name;
#pragma warning restore CA1416 // Validate platform compatibility

            ViewBag.UserName = _string;




            return View();

        }

        public IActionResult MyNetworkInfo()
        {
            ViewBag.Nampage = "My Network info";
#pragma warning disable CA1416 // Validate platform compatibility
            var _String = WindowsIdentity.GetCurrent().Name;
            ViewBag.UserName = _String;

            Ping ping = new Ping();
            /*  var ipaddress= System.Net.IPAddress.Parse("192.168.1.25");
            ipaddress.GetAddressBytes();*/

            PingReply reply = ping.Send("www.visualstudio.microsoft.com");

            

            return View(reply);
        }

        public IActionResult MachineServices()
        {
#pragma warning disable CA1416 // Validate platform compatibility
            var _String = WindowsIdentity.GetCurrent().Name;

            ViewBag.UserName = _String;

            Process[] Myprocessinfo = Process.GetProcesses("LapTopHome");

            var Processs = Myprocessinfo.ToList();

            return View(Processs);
        }

        public async Task<IActionResult> ApiCall()
        {

            HttpClient client = new HttpClient();

            string? info = await client.GetStringAsync("https://localhost:44346/api/Example");
            List<NetworkDetails>? Deobj = JsonConvert.DeserializeObject<List<NetworkDetails>>(info);

            var Objlist = Deobj.ToList();


            return View(Objlist);
        }

     
         public IActionResult NavigationTips()
        {

            return View();
        }





    }
}