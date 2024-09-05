using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
