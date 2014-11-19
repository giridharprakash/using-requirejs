using System.Web;
using System.Web.Optimization;

namespace RequirejsDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/requirejs").Include(
                        "~/content/libraries/require.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/content/libraries/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/content/libraries/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/content/libraries/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/content/libraries/bootstrap.js",
                      "~/content/libraries/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/underscore").Include(
                        "~/content/libraries/underscore-min.js"));

            bundles.Add(new ScriptBundle("~/bundles/backbone").Include(
                        "~/content/libraries/backbone.js"));

            bundles.Add(new StyleBundle("~/Content/stylesheets/css").Include(
                      "~/content/stylesheets/bootstrap.css",
                      "~/content/stylesheets/site.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
