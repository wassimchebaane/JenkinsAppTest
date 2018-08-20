using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsAppTest.Startup))]
namespace JenkinsAppTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
