using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuirkyBookRentals.Startup))]
namespace QuirkyBookRentals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
