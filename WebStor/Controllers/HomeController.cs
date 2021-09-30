﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStor.Models;

namespace WebStor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult ContactUs() => View();

        public IActionResult Status(string Code) => Content($"Status code - {Code}");


    }
}
