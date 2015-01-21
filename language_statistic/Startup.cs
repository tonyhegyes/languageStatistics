using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(language_statistic.Startup))]
namespace language_statistic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
