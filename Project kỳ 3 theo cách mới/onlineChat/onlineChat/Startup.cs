using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(onlineChat.Startup))]
namespace onlineChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
