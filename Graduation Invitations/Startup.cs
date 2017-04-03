using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Graduation_Invitations.Startup))]
namespace Graduation_Invitations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
