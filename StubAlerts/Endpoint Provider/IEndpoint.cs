using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubAlerts.Providers
{
    public interface IEndpoint
    {
        void SendAlert(Receiver receiver, Alert alert);
    }
}
