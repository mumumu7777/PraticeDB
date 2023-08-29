using demo2.Models.EFModel;
using System.Linq;
using System.Web.Mvc;

namespace demo2.Controllers
{
    public class TestController : Controller
    {

        //private readonly PraticeDbEntities1 _PraticeDb;

        //public TestController(PraticeDbEntities1 praticeDb)
        //{
        //    _PraticeDb = praticeDb;
        //}

        // GET: Test
        public ActionResult Index()
        {

           //var student = _PraticeDb.FinalScore.First().Student;
           // ViewBag.test = student;


            return View();
        }
    }
}