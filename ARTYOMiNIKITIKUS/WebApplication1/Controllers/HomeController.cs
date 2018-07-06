using System.Web.Mvc;
using ARTYOMiNIKITIKUS;
using ARTYOMiNIKITIKUS.TwoArguments;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "Multiplication", Text ="Multiplication"
                },
                new SelectListItem()
                {
                    Value = "Plus", Text ="Plus"
                },
                new SelectListItem()
                {
                    Value = "Minus", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "Division", Text ="Division"
                }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(double firstArgument, double secondArgument, string operation)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstArgument, secondArgument);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "Multiplication", Text ="Multiplication"
                },
                new SelectListItem()
                {
                    Value = "Plus", Text ="Plus"
                },
                new SelectListItem()
                {
                    Value = "Minus", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "Division", Text ="Division"
                }
            };
            return View();
        }
    }
}