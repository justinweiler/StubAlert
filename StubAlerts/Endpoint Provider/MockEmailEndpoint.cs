using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;

namespace StubAlerts.Providers
{
    public class MockEmailEndpoint : IEndpoint
    {
        public void SendAlert(Receiver receiver, Alert alert)
        {
            Thread.Sleep(5000);
            Debug.WriteLine("EMail {0} sent", alert.AlertMessage);
        }
    }
}