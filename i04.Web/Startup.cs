using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using i04.Web.Hubs;

[assembly: OwinStartup(typeof(i04.Web.Hubs.Startup))]

namespace i04.Web.Hubs
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}