using ITMO.ASPNET.Test.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASPNET.Test.Controllers
{
    public class StudentsController : Controller
    {
        StudentsEntities db = new StudentsEntities();       

        // GET: Students        
        public ActionResult AllStudents()
        {
            return View(db.Students);
        }

        public ActionResult AddStudent()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return View("AllStudents", db.Students);
            }
            return View();
        }

        public ActionResult DeleteStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteStudent(string studentId)
        {            
            bool check = int.TryParse(studentId, out int result);

            if (check)
            {
                Student student = db.Students.Find(result);

                if (student == null)
                {
                    ModelState.AddModelError("StudentId", "Студент с таким ID не существует");
                }

                if (ModelState.IsValid)
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                    return View("AllStudents", db.Students);
                }
                else
                {
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("StudentId", "Поле ID должно быть заполнено и может содержать только цифры");                
            }
         
            return View();
        }

        public ActionResult Sum()
        {
            ViewBag.Sum = db.GetSum();
            return View();
        }

        public ActionResult BestStudents()
        {
            ViewBag.BestStudents = db.GetBestStudents();
            return View();
        }

        public ActionResult WorseStudents()
        {
            ViewBag.WorseStudents = db.GetWorseStudents();
            return View();
        }
    }
}