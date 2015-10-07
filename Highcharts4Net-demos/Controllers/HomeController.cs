using System.Web.Mvc;

namespace Highcharts4Net_demos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToActionPermanent("Index","LineCharts");
        }

    }
}
