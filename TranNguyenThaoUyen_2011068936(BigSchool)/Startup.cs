using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranNguyenThaoUyen_2011068936_BigSchool_.Startup))]
namespace TranNguyenThaoUyen_2011068936_BigSchool_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
