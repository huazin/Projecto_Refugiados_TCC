using System.Web;
using System.Web.Optimization;

namespace ProjetoRefugiados.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/Select2.full.min.js",
                        "~/Scripts/Select2.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/select2.min.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/Acejs").Include(
                      "~/ace/js/jquery-ui.custom.min.js",
                      "~/ace/js/jquery.ui.touch-punch.min.js",
                      "~/ace/js/jquery.easypiechart.min.js",
                      "~/ace/js/jquery.sparkline.index.min.js",
                      "~/ace/js/jquery.flot.min.js",
                      "~/ace/js/jquery.flot.pie.min.js",
                      "~/ace/js/jquery.flot.resize.min.js",
                      "~/ace/js/bootbox.js",
                      "~/ace/js/ace-elements.min.js",
                      "~/ace/js/ace.min.js"
                ));

            bundles.Add(new StyleBundle("~/Content/AceCss").Include(
                      "~/ace/css/fonts.googleapis.com.css",
                      "~/ace/css/ace.min.css",
                      "~/ace/css/ace-skins.min.css",
                      "~/ace/css/ace-rtl.min.css",
                      "~/ace/css/fonts.googleapis.com.css"
                ));
        }
    }
}
