using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRtest.SignalR.Startup))]

namespace SignalRtest.SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}