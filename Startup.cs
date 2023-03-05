using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(web_chat.Startup))]
namespace web_chat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}