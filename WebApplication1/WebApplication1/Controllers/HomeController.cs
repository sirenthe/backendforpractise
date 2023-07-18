using Microsoft.AspNetCore.Mvc;
 using  WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        
            public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student() {Id=1, Name="Laman", Surname="Jananova", Point=67},
                new Student() {Id=1, Name="Laman", Surname="Jananova", Point=67},
            };

            //string name = "leman";
            //ViewBag.Name = name;
            //ViewData["Name"] = name;
            //TempData["Name"] = name;

            //return RedirectToAction("Test");
            return View(students);
            }
            public string Test()
            {
                return "test";
            }
        }

    }

