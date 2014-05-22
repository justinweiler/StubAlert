using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StubAlerts.Providers
{
    public class Receiver
    {
        public string Type {  get; set; }
        public string Endpoint {  get; set; }
        public string Protocols {  get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
    }
}