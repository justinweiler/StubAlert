using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StubAlerts.Providers
{
    public class MockEndpointProvider : IEndpointProvider
    {
        private Dictionary<string, IEndpoint> _endpointLookup = new Dictionary<string, IEndpoint>();

        public MockEndpointProvider()
        {
            // config bind here
            _endpointLookup.Add("REST", new MockRESTEndpoint());
            _endpointLookup.Add("SMTP", new MockEmailEndpoint());
        }

        public void SendAlert(Receiver receiver, Alert alert)
        {
            _endpointLookup[receiver.Protocols].SendAlert(receiver, alert);
        }
    }
}