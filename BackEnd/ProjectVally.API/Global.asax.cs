using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ProjectVally.API.AutoMapper;

namespace ProjectVally.API
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.RegisterMappings();
            AreaRegistration.RegisterAllAreas();
        }
    }
}
