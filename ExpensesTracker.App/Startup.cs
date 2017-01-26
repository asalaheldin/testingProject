using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpensesTracker.App.Startup))]
namespace ExpensesTracker.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
