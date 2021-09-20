using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStor.Models;

namespace WebStor.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> _Employees = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 27 },
            new Employee { Id = 2, LastName = "Петров", FirstName = "Пётр", Patronymic = "Петрович", Age = 31 },
            new Employee { Id = 3, LastName = "Сидоров", FirstName = "Сидор", Patronymic = "Сидорович", Age = 18 },
        };
        public IActionResult Index()
        {
            //return Content("Hello from first controller");
            return View();

        }

        public IActionResult SecondAction(string id) 
        {
            return Content($"Second action with parameter {id}");
        }

        public IActionResult Employees() 
        {
            return View(_Employees);
        }
    }
}
