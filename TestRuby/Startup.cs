using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestRuby.Startup))]
namespace TestRuby
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
