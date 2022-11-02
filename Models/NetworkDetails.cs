using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;

namespace PersonalExampleWebPage.Models
{
    public class NetworkDetails
    {

        public string? LocalMachine { get; set; }
        public string? HostAddress { get; set; }  

        public string? ReachableHost { get; set; }  



    }
}
