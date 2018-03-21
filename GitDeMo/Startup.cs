using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitDeMo.Startup))]
namespace GitDeMo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
