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
    [ServiceContract]
    public interface ISendAlert
    {
        [OperationContract]
        Task<string> SendAlert(Alert alert);
    }

    [DataContract]
    public class Alert
    {
        int[] receivers;
        string alertMessage;
        DateTime alertTime;

        [DataMember]
        public int[] Receivers
        {
            get { return receivers; }
            set { receivers = value; }
        }

        [DataMember]
        public DateTime AlertTime
        {
            get { return alertTime; }
            set { alertTime = value; }
        }

        [DataMember]
        public string AlertMessage
        {
            get { return alertMessage; }
            set { alertMessage = value; }
        }
    }
}
