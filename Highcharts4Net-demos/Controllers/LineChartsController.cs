using System.Web.Mvc;

namespace Highcharts4Net_demos.Controllers
{
    public class LineChartsController : Controller
    {
        // GET: ~/LineCharts
        public ActionResult Index()
        {
            return RedirectToAction("Basic");
        }

        // GET: ~/LineCharts/Basic
        public ActionResult Basic()
        {
            return View();
        }

        // GET: ~/LineCharts/AjaxLoadedClickablePoints
        public ActionResult AjaxLoadedClickablePoints()
        {
            return View();
        }

        // GET: ~/LineCharts/WithDataLabels
        public ActionResult WithDataLabels()
        {
            return View();
        }

        // GET: ~/LineCharts/TimeSeries
        public ActionResult TimeSeries()
        {
            return View();
        }

        // GET: ~/LineCharts/SplineInverted
        public ActionResult SplineInverted()
        {
            return View();
        }

        // GET: ~/LineCharts/SplineWithSymbols
        public ActionResult SplineWithSymbols()
        {
            return View();
        }

        // GET: ~/LineCharts/SplineWithPlotBands
        public ActionResult SplineWithPlotBands()
        {
            return View();
        }
    }
}