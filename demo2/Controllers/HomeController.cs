using demo2.Models.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo2.Models.DTOs;
using System.Data.Entity.Migrations;
using System.Runtime.Remoting.Contexts;
using Microsoft.Ajax.Utilities;

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

        //public ActionResult UpdateScore(int studentid, string subject, int score)
        //{
        //    try
        //    {               
        //        var studentscore = _PraticeDb.Score.First(x => x.StudentId == studentid && x.Subject == subject);
        //        studentscore.Score1 = score;
                
        //        if (studentscore == null)
        //        {
        //            throw new Exception("資料有誤");
        //        }                
        //        _PraticeDb.SaveChanges();
        //        return View();
        //    }
        //    catch (Exception ex)
        //    {
        //        return View();
        //    }
        //}
        public ActionResult CreateStudent(string name, string gender, int classid)
        {
            var student = _PraticeDb.Student;
            var addData = new Student() { 姓名 = name, 性別 = gender, 班級 = classid };
            student.Add(addData);
            return View() ;  
        }

        [HttpPost]
        public ActionResult DeleteClass(int classID)
        {
            try
            {
                

                if (classID==null) { }



                var classes = _PraticeDb.Class.First(x => x.id == classID);
                _PraticeDb.Class.Remove(classes);
                _PraticeDb.SaveChanges();
                return Json("ok");
            }
            catch (Exception ex) {
                return Json("ERROR");
            };
           
        }
        [HttpPost]
        public ActionResult AddAllScore()
        {
            //foreach

            return Json(null);
        }

        public ActionResult AddToPassScore()
        {
            int index = 0;         
            var scores = _PraticeDb.Score.Select(x => x.Score1).ToList();
            foreach (int score in scores)
            {                                     
                //if (score<60) { scores[index] = 60; continue; index++; }
                switch (score)
                {
                    case int scorecase when (scorecase <60):
                        scores[index] = 60;                      
                        break;
                };
                index++;
            }
            _PraticeDb.SaveChanges();
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