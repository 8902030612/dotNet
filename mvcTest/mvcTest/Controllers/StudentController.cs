using Microsoft.AspNetCore.Mvc;
using mvcTest.Models;

namespace mvcTest.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ShowStudentDet()
        {
            Studentmodel student = new Studentmodel()
            {
                int StudentId = studentmodel.StudentId;
                string StudentName = studentmodel.StudentName;
                string Department = studentmodel.Department;
                string Course = studentmodel.Course;
            };
            
            

            return View();
        }
    }
}
