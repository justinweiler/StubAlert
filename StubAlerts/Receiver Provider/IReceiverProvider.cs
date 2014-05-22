using StubAlerts.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubAlerts.Providers
{
    public interface IReceiverProvider
    {
        Receiver GetReceiver(int receiverID);
    }
}
