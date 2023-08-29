using demo2.Models.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo2.Models.DTOs;
using System.Data.Entity.Migrations;
using System.Runtime.Remoting.Contexts;

namespace demo2.Controllers
{
    public class HomeController : Controller
    {

        private readonly PraticeDbEntities1 _PraticeDb;

        public HomeController(PraticeDbEntities1 praticeDb)
        {
            _PraticeDb = praticeDb;
        }

        public ActionResult Index()
        {
            var data = new PraticeDbEntities1();
            //string connectionString = data.Database.Connection.ConnectionString;
            string test = "123";
            ViewBag.test = data.Score.First().Subject;

            return View();
        }

        public ActionResult UpdateScore(int studentid, string subject, int score)
        {

            try
            {

                //switch{ }

                var studentscore = _PraticeDb.Score.First(x => x.StudentId == studentid && x.Subject == subject);

                studentscore.Score1 = score;

                //if ()
                //{
                    
                //}
                if (studentscore == null)
                {
                    throw new Exception("資料有誤");
                }
                
                _PraticeDb.SaveChanges();

                return View();
            }

            catch (Exception ex)
            {

                return View();

            }



        }


        [HttpPost]
        public ActionResult CreateStudent(/*int id , string name , string gender*/ )
        {
            var student = _PraticeDb.Student.First(x => x.id == 1);





            return View(student) ;  
        }



        //public IEnumerable<>



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