using System.Web;
using System.Web.Optimization;

namespace ExpressoUrbano.Presentation
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquerymin").Include(
                "~/Scripts/jquery.min.js",
                "~/Scripts/jquery.maskedinput.js",
                "~/Scripts/jquery-2.2.0.min.js",
                "~/Scripts/jquery.maskMoney.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Content/js/jquery.easing.1.3.js",
                "~/Content/js/charts/jquery.flot.js",
                "~/Content/js/charts/jquery.flot.time.js",
                "~/Content/js/charts/jquery.flot.animator.min.js",
                "~/Content/highchart/js/highcharts.js",
                "~/Content/highchart/js/modules/exporting.js",
                "~/Content/highchart/js/themes/dark-unica.js",
                "~/Content/highchart/js/jquery.flot.resize.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/daterangepicker").Include(
            //    "~/Scripts/moment.min.js",
            //    "~/Scripts/daterangepicker.js",
            //    "~/Scripts/myDaterange.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Content/js/bootstrap.min.js",
                "~/Scripts/jquery-ui/jquery-ui.min.js",
                "~/Content/js/maps/jvectormap.min.js",
                "~/Content/js/maps/usa.js",
                "~/Content/js/icheck.js",
                "~/Content/js/scroll.min.js",
                "~/Content/js/calendar.min.js",
                "~/Content/js/feeds.min.js",
                //"~/Content/js/validation/validate.min.js",
                //"~/Content/js/jquery.validate.js",
                //"~/Content/js/validation/validationEngine.min.js",
                //"~/Scripts/jquery.validate.min.js",
                //"~/Scripts/jquery.validate.unobtrusive.min.js",
                "~/Content/js/select.min.js",
                "~/Content/js/chosen.min.js",
                //"~/Content/js/datetimepicker.min.js",
                "~/Content/js/colorpicker.min.js",
                "~/Content/js/bootstrap-colorpicker.min.js",
                "~/Content/js/autosize.min.js",
                "~/Content/js/toggler.min.js",
                "~/Content/js/input-mask.min.js",
                "~/Content/js/spinner.min.js",
                "~/Content/js/slider.min.js",
                "~/Content/js/fileupload.min.js",
                "~/Content/js/docs.js",
                "~/Content/js/editor.min.js",
                "~/Content/js/markdown.min.js",
                "~/Scripts/jquery.unobtrusive-ajax.min.js",
                "~/Scripts/ace-elements.min.js",
                "~/Scripts/ace.min.js",
                "~/Scripts/fileinput.min.js",
                "~/Scripts/Funcoes/Funcoes.js",
                "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/bower").Include(
                "~/Content/vendors/bower_components/jquery/dist/jquery.min.js",
                "~/Content/js/input-mask.min.js",
                //"~/Content/js/chosen.min.js",
                "~/Content/vendors/bower_components/bootstrap/dist/js/bootstrap.min.js",
                "~/Content/vendors/bower_components/chosen/chosen.jquery.min.js",
                "~/Content/vendors/bower_components/autosize/dist/autosize.min.js",
                "~/Content/js/timer.jquery.min.js",
                "~/Content/vendors/fileinput/fileinput.min.js"
                ));


            bundles.Add(new ScriptBundle("~/bundles/jsTemplate").Include(
                "~/Scripts/jquery.unobtrusive-ajax.min.js",
                //"~/Content/vendors/bower_components/jquery.validate.js",
                //"~/Scripts/jquery.validate.unobtrusive.min.js",
                "~/Scripts/jquery-ui/jquery-ui.min.js",
                "~/Content/vendors/bower_components/bootstrap/dist/js/bootstrap.min.js",
                "~/Content/vendors/bower_components/moment/moment-with-locales.js",
                "~/Content/vendors/bower_components/eonasdan-bootstrap-datetimepicker/build/js/bootstrap-datetimepicker.min.js",
                //"~/Content/Datapicker/locales/bootstrap-datepicker.pt-BR.min.js",
                "~/Content/vendors/bower_components/fullcalendar/dist/fullcalendar.min.js",
                "~/Content/vendors/bower_components/simpleWeather/jquery.simpleWeather.min.js",
                "~/Content/vendors/bower_components/Waves/dist/waves.min.js",
                "~/Content/vendors/bootstrap-growl/bootstrap-growl.min.js",
                "~/Content/vendors/bower_components/bootstrap-sweetalert/lib/sweet-alert.min.js",
                "~/Content/vendors/bower_components/malihu-custom-scrollbar-plugin/jquery.mCustomScrollbar.concat.min.js",
                "~/Content/senhaforte/pwstrength-bootstrap.js",
                //"~/Content/Datapicker/js/bootstrap-datepicker.js",
                "~/Scripts/Funcoes/Funcoes.js",
                "~/Scripts/CEP/consulta-cep.js",
                //"~/Scripts/Password/password-strength-popover.js",
                "~/Content/js/functions.js"
                //,"~/Content/js/demo.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/animate.min.css",
                "~/Content/css/font-awesome.min.css",
                "~/Content/css/form.css",
                "~/Content/css/calendar.css",
                "~/Scripts/jquery-ui/jquery-ui.min.css",
                "~/Scripts/jquery-ui/jquery-ui.theme.min.css",
                "~/Content/css/style.css",
                "~/Content/css/icons.css",
                "~/Content/css/generics.css",
                "~/Content/css/docs.css",
                "~/Content/css/bootstrap-colorpicker.min.css",
                "~/Content/css/app.min.1.css",
                //"~/Content/Password/Password.css",
                "~/Content/css/app.min.2.css"));

            bundles.Add(new StyleBundle("~/Content/cssTemplate").Include(
                "~/Content/vendors/bower_components/fullcalendar/dist/fullcalendar.min.css",
                "~/Content/vendors/bower_components/animate.css/animate.min.css",
                "~/Content/vendors/bower_components/bootstrap-sweetalert/lib/sweet-alert.css",
                "~/Content/vendors/bower_components/material-design-iconic-font/dist/css/material-design-iconic-font.min.css",
                "~/Content/vendors/bower_components/malihu-custom-scrollbar-plugin/jquery.mCustomScrollbar.min.css",
                "~/Content/vendors/bower_components/bootstrap-select/dist/css/bootstrap-select.css",
                "~/Content/vendors/bower_components/nouislider/distribute/jquery.nouislider.min.css",
                "~/Content/vendors/farbtastic/farbtastic.css",
                "~/Content/vendors/bower_components/chosen/chosen.min.css",
                "~/Content/vendors/summernote/dist/summernote.css",
                "~/Content/vendors/bower_components/eonasdan-bootstrap-datetimepicker/build/css/bootstrap-datetimepicker.min.css",
                "~/Content/css/app.min.1.css",
                "~/Content/Site.css",   
                "~/Content/css/style.css",
                
                //"~/Content/Password/Password.css",
                "~/Content/css/app.min.2.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-touch.js",
                "~/Scripts/angular-animate.js",
                "~/Scripts/ui-grid.js",
                "~/Scripts/app.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/angularSite").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-touch.js",
                "~/Scripts/angular-animate.js",
                "~/Scripts/ui-grid.js",
                "~/Scripts/appSite.js"
                ));

            bundles.Add(new StyleBundle("~/Content/uicss").Include(
                "~/Content/ui-grid.css",
                "~/Content/ui-grid.eot",
                "~/Content/ui-grid.svg",
                "~/Content/ui-grid.tff",
                "~/Content/ui-grid.woff"
                ));

            bundles.Add(new StyleBundle("~/Content/sitecss").Include(
                "~/Content/vendors/bower_components/fullcalendar/dist/fullcalendar.min.css",
                "~/Content/vendors/bower_components/animate.css/animate.min.css",
                "~/Content/vendors/bower_components/bootstrap-sweetalert/lib/sweet-alert.css",
                "~/Content/vendors/bower_components/material-design-iconic-font/dist/css/material-design-iconic-font.min.css",
                "~/Content/vendors/bower_components/malihu-custom-scrollbar-plugin/jquery.mCustomScrollbar.min.css",
                "~/Content/css/app.min.1.css",
                "~/Content/css/app.min.2.css",
                "~/Content/css/custom.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/sitejs").Include(
                "~/Content/vendors/bower_components/jquery/dist/jquery.min.js",
                "~/Content/vendors/bower_components/bootstrap/dist/js/bootstrap.min.js",
                "~/Content/vendors/bower_components/flot/jquery.flot.js",
                "~/Content/vendors/bower_components/flot/jquery.flot.resize.js",
                "~/Content/vendors/bower_components/flot.curvedlines/curvedLines.js",
                "~/Content/vendors/sparklines/jquery.sparkline.min.js",
                "~/Content/vendors/bower_components/jquery.easy-pie-chart/dist/jquery.easypiechart.min.js",
                "~/Content/vendors/bower_components/moment/min/moment.min.js",
                "~/Content/vendors/bower_components/fullcalendar/dist/fullcalendar.min.js",
                "~/Content/vendors/bower_components/simpleWeather/jquery.simpleWeather.min.js",
                "~/Content/vendors/bower_components/malihu-custom-scrollbar-plugin/jquery.mCustomScrollbar.concat.min.js",
                "~/Content/vendors/bower_components/Waves/dist/waves.min.js",
                "~/Content/vendors/bootstrap-growl/bootstrap-growl.min.js",
                "~/Content/vendors/bower_components/bootstrap-sweetalert/lib/sweet-alert.min.js",
                "~/Content/js/flot-charts/curved-line-chart.js",
                "~/Content/js/flot-charts/line-chart.js",
                "~/Content/js/charts.js",
                "~/Content/js/charts.js",
                "~/Content/js/functions.js",
                "~/Content/js/demo.js"
                ));
            BundleTable.EnableOptimizations = false;
        }
    }
}
