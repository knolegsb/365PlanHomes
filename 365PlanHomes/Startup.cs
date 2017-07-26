using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_365PlanHomes.Startup))]
namespace _365PlanHomes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
