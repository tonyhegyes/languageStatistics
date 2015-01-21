using System.Web;
using System.Web.Optimization;

namespace language_statistic
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region SCRIPTS
                bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

                bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));

                bundles.Add(new StyleBundle("~/bundles/yepnope").Include("~/Scripts/yepnope.*"));
                bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));
                bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
            #endregion
            #region STYLES
                bundles.Add(new StyleBundle("~/Content/css").Include(
                          "~/Content/bootstrap.css",
                          "~/Content/zocial.css",
                          "~/Content/site.css"));
            #endregion
            #region POLYFILLS
                bundles.Add(new ScriptBundle("~/bundles/jreject").Include("~/Scripts/jquery.reject.js"));
                bundles.Add(new StyleBundle("~/bundles/jrejectCSS").Include("~/Content/polyfills/jquery.reject.css"));

                bundles.Add(new ScriptBundle("~/bundles/jquerytextshadow").Include("~/Scripts/jquery.textshadow.js"));
                bundles.Add(new StyleBundle("~/bundles/jquerytextshadowCSS").Include("~/Content/polyfills/jquery.textshadow.css"));

                bundles.Add(new ScriptBundle("~/bundles/oldIEBrowsersSupport").Include("~/Scripts/respond.js", "~/Scripts/html5shiv.js"));
            #endregion

            BundleTable.EnableOptimizations = false;
        }
    }
}
