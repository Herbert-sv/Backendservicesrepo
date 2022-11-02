using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalExampleWebPage.Models;
using Newtonsoft.Json;
using System.Security.Principal;
using System.Net.NetworkInformation;
using System.Net;

namespace PersonalExampleWebPage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public string NetworkDetails()
        {
#pragma warning disable CA1416 // Validate platform compatibility
            string str_Win = WindowsIdentity.GetCurrent().Name;

#pragma warning disable CA1416 // Validate platform compatibility

            Ping ping = new Ping();
            PingReply Reply= ping.Send("www.Dell.com");
               
            IPAddress Ip =Reply.Address;
            PingReply ReplyOne = ping.Send("www.visualstudio.microsoft.com");

            IPAddress IpOne = ReplyOne.Address;

            PingReply ReplyTwo = ping.Send("www.Google.com");

            IPAddress IpTwo = ReplyTwo.Address;


            List<NetworkDetails> Ndbjs=new List<NetworkDetails>();
            
            NetworkDetails Ndobj = new NetworkDetails();

            Ndobj.LocalMachine = str_Win;

            Ndobj.HostAddress = "www.Dell.com";

            Ndobj.ReachableHost = Ip.ToString();

            NetworkDetails NdobjOne = new NetworkDetails();

            NdobjOne.LocalMachine = str_Win;

            NdobjOne.HostAddress = "www.visualstudio.microsoft.com";

            NdobjOne.ReachableHost = IpOne.ToString();

            NetworkDetails NdobjTwo = new NetworkDetails();

            NdobjTwo.LocalMachine = str_Win;

            NdobjTwo.HostAddress = "www.Google.com";

            NdobjTwo.ReachableHost = IpTwo.ToString();

            Ndbjs.Add(Ndobj);
            Ndbjs.Add(NdobjOne);
            Ndbjs.Add(NdobjTwo);

            
            string stringJson=JsonConvert.SerializeObject(Ndbjs.ToList());


            return stringJson;
        
        }
    }
}
