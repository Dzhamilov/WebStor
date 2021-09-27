﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStor.Data;
using WebStor.Models;

namespace WebStor.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEnumerable<Employee> _Employees;

        public EmployeesController()
        {
            _Employees = TestData.Employees;
        }

        public IActionResult Index() => View(_Employees);

        public IActionResult Details(int id)
        {
            //var employee = _Employees.FirstOrDefault(e => e.Id == id);
            var employee = _Employees.SingleOrDefault(e => e.Id == id);

            if (employee is null)
                return NotFound();

            return View(employee);
        }


        public IActionResult TestAction(string Parameter1, int Param2)
        {
            return Content($"P1:{Parameter1} - P2:{Param2}");
        }

    }
}
