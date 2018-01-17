using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCHomeworkDay1.Startup))]
namespace MVCHomeworkDay1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
