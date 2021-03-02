using Microsoft.AspNet.SignalR;

namespace SignalRtest.Models
{
    public class BroadcastHub : Hub
    {
        public void Broadcast(string name, string message)
        {
            Clients.All.showmessage(name, message);
        }
    }
}