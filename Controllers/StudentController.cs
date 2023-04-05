using Microsoft.AspNetCore.Mvc;
using MVCTraining.Models.DemoModels;

namespace MVCTraining.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<StudentModel> students = new List<StudentModel>
            {
                new StudentModel{ Id = 01, Name="Prince"},
                new StudentModel{ Id = 02, Name="Kumar"},
                new StudentModel{ Id = 03, Name="Sakshi"},
                new StudentModel{ Id = 04, Name="Singh"},
            };

            List<CourseModel> courses = new List<CourseModel>
            {
                new CourseModel{ Id =101, Name="CSE"}, new CourseModel{Id=102,Name="BCA"}
            };



            return View(students);
        }
    }
}
