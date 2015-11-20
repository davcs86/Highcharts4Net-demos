using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Highcharts4Net_demos.Controllers
{
    public class ColumnAndBarChartsController : Controller
    {
        // GET: ColumnAndBarCharts
        public ActionResult Index()
        {
            return RedirectToAction("BasicBar");
        }

        public ActionResult BasicBar()
        {
            return View();
        }

        public ActionResult StackedBar()
        {
            return View();
        }

        public ActionResult BarWithNegatives()
        {
            return View();
        }

        public ActionResult BasicColumn()
        {
            return View();
        }

        public ActionResult ColumnWithNegatives()
        {
            return View();
        }

        public ActionResult StackedColumn()
        {
            return View();
        }

        public ActionResult StackedGroupedColumn()
        {
            return View();
        }

        public ActionResult StackedPercentageColumn()
        {
            return View();
        }

        public ActionResult RotatedLabelsColumn()
        {
            return View();
        }
    }
}