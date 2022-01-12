using School_ProjectMVC_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_ProjectMVC_Web_API.Controllers
{
    public class StudentController : Controller
    {
        Student[] students = new Student[]
        {
            new Student(11,"lior","yosef","A",12),
            new Student(12,"eilay","yosef","b",13),
            new Student(13,"avi","yosef","c",14)

        };
        // GET: Student
        public ActionResult Index()
        {
            return View(students[0]);
            
        }

        public ActionResult StudentName()
        {
            return View(students[0]);

        }
        public ActionResult GetAll()
        {
            return View(students);
        }
        public ActionResult StudentById(int id)
        {
           foreach (Student student in students)
            {
                if(student.Id == id)
                {
                    return View(student);
                }
            }

            return View("not fuond");

        }


    }
}