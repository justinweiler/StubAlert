using StubAlerts.Receiver_Provider.ReceiverTableAdapters;
using System.Linq;

namespace StubAlerts.Providers
{
    public class SQLReceiverProvider : IReceiverProvider
    {
        private ReceiversTableAdapter _adapter = new ReceiversTableAdapter();
        private Receiver_Provider.Receiver.ReceiversDataTable _dataTable; 

        public Receiver GetReceiver(int receiverID)
        {
            _adapter.Connection.Open();
            _dataTable = _adapter.GetData();
            var receivers = from row in _dataTable 
                            where row.Id == receiverID
                            select new Receiver() { 
                               Type = row.Type, Endpoint = row.Endpoint,
                               Protocols = row.Protocols, User = row.User,
                               Pass = row.Pass};
            _adapter.Connection.Close();
            return receivers.First();
        }
    }
}