using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryAppSmirnov.Startup))]
namespace LibraryAppSmirnov
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
