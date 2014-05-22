using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace StubAlerts.Providers
{
    public class MockRESTEndpoint : IEndpoint
    {
        public void SendAlert(Receiver receiver, Alert alert)
        {
            Debug.WriteLine("REST {0} sent", alert.AlertMessage);
        }
    }
}