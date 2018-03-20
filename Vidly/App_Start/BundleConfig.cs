using System.Web;
using System.Web.Optimization;

namespace Vidly.App_Start
{
    public class BundleConfig
    {
        
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                .Include("~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap-lux.css"));

            bundles.Add(new StyleBundle("~/bundle/bootstrap-styles")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-lux.css")
                .Include("~/Content/Site.css"));
            bundles.Add(new StyleBundle("~/bundle/Home/Index-styles")
                .Include("~/Content/StyleSheet1.css")
                .Include("~/Content/StyleSheet2.css")
                .Include("~/Content/StyleSheet3.css"));

            bundles.Add(new ScriptBundle("~/bundle/bootstrap-scripts")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/modernizr-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundle/Home/Index-scripts")
                .Include("~/Scripts/JavaScript1.js")
                .Include("~/Scripts/JavaScript2.js")
                .Include("~/Scripts/JavaScript3.js"));
        }
    }
}
