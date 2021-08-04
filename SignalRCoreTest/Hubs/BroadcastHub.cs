using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRCoreTest.Hubs
{
    public class BroadcastHub :Hub
    {

        public async Task Broadcast(string name, string message)
        {
            await Clients.All.SendAsync("showmessage", name, message);
        }
        public async Task TaskResult(string msg) 
        {
            await Clients.All.SendAsync("WebTaskResult",msg);
        }
    }
}
