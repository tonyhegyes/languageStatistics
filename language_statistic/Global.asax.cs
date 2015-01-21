using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using language_statistic.DALs;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using language_statistic.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace language_statistic
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static LanguageContext db_languages;
        public static ResourceContext db_resources;
        public static UserManager<ApplicationUser> user_manager;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //
            db_languages = new LanguageContext();
            db_resources = new ResourceContext();
            user_manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        }
    }
}
