﻿using System.Web;
using System.Web.Optimization;

namespace NaumanSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/freelancer.css",
                      //"~/Content/font-awesome.min.css"
                      "~/Content/fontawesome"
                      //"~/Content/blueimp-gallery.min.css",
                      //"~/Content/bootstrap-image-gallery.min.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/freelancer").Include(
                      
                      "~/Scripts/jquery.easing.min.js",
                      "~/Scripts/classie.js",
                      "~/Scripts/freelancer.js",
                      "~/Scripts/contact_me.js",
                      "~/Scripts/cbpAnimatedHeader.js",
                      "~/Scripts/jqBootstrapValidation.js"

                      ));

            bundles.Add(new ScriptBundle("~/bundles/gallery").Include(
                      "~/Scripts/Bootstrap-Image-Gallery.js",
                      "~/Scripts/jquery.blueimp-gallery.min.js"
                      ));
        }
    }
}
