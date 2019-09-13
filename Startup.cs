using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gl155914_MIS4200.Startup))]
namespace gl155914_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
