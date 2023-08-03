using CoreMVC_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC_WebApplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _studentContext;

        public StudentController(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public IActionResult StudentList()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }
    }
}
