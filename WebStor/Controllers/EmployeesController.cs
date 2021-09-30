using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStor.Data;
using WebStor.Models;
using WebStor.Services.Interfaces;

namespace WebStor.Controllers
{
    //[Route("Employees/[action]/{id?}")]
    //[Route("Staff/[action]/{id?}")] 

    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _EmployeesData;
        private readonly ILogger<EmployeesController> _Logger;

        public EmployeesController(IEmployeesData EmployeesData, ILogger<EmployeesController> Logger)
        {
            _EmployeesData = EmployeesData;
            _Logger = Logger;
        }

        //[Route("~/employees/all")]
        public IActionResult Index() => View(_EmployeesData.GetAll());

        //[Route("~/employees/info-{id}")]
        public IActionResult Details(int id)
        {
            //var employee = _Employees.FirstOrDefault(e => e.Id == id);
            var employee = _EmployeesData.GetById(id);

            if (employee is null)
                return NotFound();

            return View(employee);
        }


    }
}
