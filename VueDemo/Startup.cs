using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VueDemo.Startup))]
namespace VueDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
