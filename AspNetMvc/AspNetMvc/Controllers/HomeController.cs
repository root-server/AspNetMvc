using System.Web.Mvc;
using DependencyInjection.Models;

namespace AspNetMvc.Controllers
{
    public class HomeController : Controller
    {
        public Warrior Warrior { get; set; }

        public ActionResult Index()
        {
            Warrior = DependencyResolver.Current.GetService<Warrior>();
            Warrior.Kill();
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
    }
}