using System.Web.Optimization;

namespace Personal_Website
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/Site/css").Include("~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/Resume/css").Include("~/Content/resume.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
            bundles.Add(new StyleBundle("~/Content/bootstrap/base").Include("~/Content/bootstrap/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/bootstrap/theme").Include("~/Content/bootstrap/bootstrap-theme.css"));

            bundles.Add(new ScriptBundle("~/bundles/scrollto").Include("~/Scripts/scrollto/jquery.scrollto.js"));

            bundles.Add(new ScriptBundle("~/bundles/resume").Include("~/Scripts/resume.js"));
        }
    }
}