using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gym_MVCApp.Startup))]
namespace Gym_MVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
