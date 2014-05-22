using StubAlerts.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace StubAlerts
{
    public class SendAlertSvc : ISendAlert
    {
        private IReceiverProvider receiverProvider;
        private IEndpointProvider endpointProvider;

        public SendAlertSvc()
        {
            // config bind here
            receiverProvider = new SQLReceiverProvider();
            endpointProvider = new MockEndpointProvider();
        }

        public async Task<string> SendAlert(Alert alert)
        {
            return await Task.Factory.StartNew<string>(_sendAlertAsync, alert);
        }

        private string _sendAlertAsync(object state)
        {
            var alert = state as Alert;

            if (alert.AlertMessage == "TEST")
            {
                return "OK";
            }

            var taskList = new List<Task>();

            foreach (int receiverID in alert.Receivers)
            {
                var receiver = receiverProvider.GetReceiver(receiverID);
                taskList.Add(Task.Run(()=>endpointProvider.SendAlert(receiver, alert)));
            }
            
            Task.WaitAll(taskList.ToArray());

            return string.Format("Alert: [{0}] Sent: {1}", alert.AlertMessage, DateTime.Now);
        }
    }
}
