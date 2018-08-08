using System.Web;
using System.Web.Optimization;

namespace WebAPIDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {

            bundles.Add(new StyleBundle("~/bundles/style").Include(
                        "~/Content/bootstrap.min.css",
                        "~/Content/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ui").Include(
                        "~/Scripts/jquery-ui-1.11.4/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/popper-utils.min.js",
                        "~/Scripts/popper.min.js",
                        "~/Scripts/bootstrap.bundle.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/analytics").Include(
                        "~/Scripts/Heatmap/heatmap.min.js",
                        "~/Scripts/Heatmap/heatmap-handler.js",
                        "~/Scripts/Maps/map-load.js",
                        "~/Scripts/zoom-handler.js"));
        }
    }
}
