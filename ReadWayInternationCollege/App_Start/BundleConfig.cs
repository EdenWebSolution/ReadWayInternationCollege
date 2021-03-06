﻿using System;
using System.Web;
using System.Web.Optimization;

namespace ReadWayInternationCollege
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            AddDefaultIgnorePatterns(bundles.IgnoreList);
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Assets/js/vendor/jquery-1.12.4.min.js",
                        "~/Assets/js/assets/owl.carousel.min.js",
                        "~/Assets/js/assets/revolution/jquery.themepunch.revolution.min.js",
                        "~/Assets/js/assets/revolution/jquery.themepunch.tools.min.js",
                        "~/Assets/js/assets/jquery.magnific-popup.min.js",
                        "~/Assets/js/assets/jquery.sticky.js",
                        "~/Assets/js/assets/jquery.counterup.min.js",
                        "~/Assets/js/assets/waypoints.min.js",
                        "~/Assets/js/assets/slick.min.js",
                        "~/Assets/js/assets/jquery.meanmenu.min.js",
                        "~/Assets/js/assets/revolution/extensions/revolution.extension.actions.min.js",
                        "~/Assets/js/assets/revolution/extensions/revolution.extension.carousel.min.js",
                        "~/Assets/js/assets/revolution/extensions/revolution.extension.kenburn.min.js",
                        "~/Assets/js/assets/revolution/extensions/revolution.extension.layeranimation.min.js",
                        "~/Assets/js/assets/revolution/extensions/revolution.extension.migration.min.js",
                        "~/Assets/js/assets/revolution/extensions/revolution.extension.navigation.min.js",
                        "~/Assets/js/assets/revolution/extensions/revolution.extension.parallax.min.js",
                        "~/Assets/js/assets/revolution/extensions/revolution.extension.slideanims.min.js",
                        "~/Assets/js/assets/revolution/extensions/revolution.extension.video.min.js",
                        "~/Assets/js/assets/revolution/revolution.js",
                        "~/Scripts/totop.min.js",
                        "~/Assets/js/custom.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Assets/js/assets/bootstrap.min.js",
                      "~/Scripts/respond.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Assets/css/assets/bootstrap.min.css",
                      "~/Assets/css/assets/font-awesome.min.css",
                      "~/Assets/css/assets/magnific-popup.css",
                      "~/Assets/css/assets/revolution/layers.css",
                      "~/Assets/css/assets/revolution/navigation.css",
                      "~/Assets/css/assets/revolution/settings.css",
                      "~/Assets/css/assets/slick.css",
                      "~/Assets/css/assets/slick-theme.css",
                      "~/Assets/css/assets/meanmenu.css",
                      "~/Assets/css/style.min.css",
                      "~/Assets/css/responsive.css"
                      ).Include("~/Assets/css/Raleway.css", new CssRewriteUrlTransform())); 


            #region toastr

            bundles.Add(new StyleBundle("~/toastr/css").Include(
            "~/Content/toastr.min.css"
            ));

            bundles.Add(new ScriptBundle("~/Bundles/toastr").Include(
                "~/Scripts/toastr.min.js"
                 ));


            #endregion

            bundles.Add(new ScriptBundle("~/Ajax-scripts").Include(
                "~/Scripts/jquery-1.10.2.min.js",
                "~/Scripts/jquery.unobtrusive-ajax.min.js"
                ));

            bundles.Add(new ScriptBundle("~/ContactUs/js").Include(
                "~/Scripts/ContactUs.js"
                ));

            BundleTable.EnableOptimizations = true;
        }
        public static void AddDefaultIgnorePatterns(IgnoreList ignoreList)
        {
            if (ignoreList == null)
                throw new ArgumentNullException("ignoreList");
            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*-vsdoc.js");
            ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
        }
    }
}
