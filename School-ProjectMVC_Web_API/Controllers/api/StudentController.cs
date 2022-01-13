using School_ProjectMVC_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace School_ProjectMVC_Web_API.Controllers.api
{
    public class StudentController : ApiController
    {
       static List<Student> ListStudent = new List<Student>();
    private void  listStu()
     {
            ListStudent.Add(new Student(1, "lior", "yosef", "abc", 12));
            ListStudent.Add(new Student(2, "avi", "yosef", "abc", 13));
     }
        

    // GET: api/Student
    public IHttpActionResult Get()
        {
            listStu();
            return Ok(ListStudent);
        }

        // GET: api/Student/5
        public IHttpActionResult Get(int id)
        {
            listStu();
            return Ok(ListStudent.Find(stu => stu.Id==id));
        }

        // POST: api/Student
        public IHttpActionResult Post([FromBody]Student value)
        {
            listStu();
            ListStudent.Add(value);
            return Ok(value);
        }

        // PUT: api/Student/5
        public IHttpActionResult Put(int id, [FromBody] Student value)
        {
            foreach (Student item in ListStudent)
            {
                if (item.Id==id)
                {
                    value.FirstName = item.FirstName;
                    value.LastName = item.LastName;
                    value.Grade = item.Grade;   
                    value.Age = item.Age;
                    return Ok(value);
                }
            }
            return Ok("not found");
            
        }

        // DELETE: api/Student/5
        public IHttpActionResult Delete(int id)
        {
            listStu();
            ListStudent.Remove(ListStudent.Find(stu => stu.Id== id));
            return Ok(ListStudent);
        }
    }
}
