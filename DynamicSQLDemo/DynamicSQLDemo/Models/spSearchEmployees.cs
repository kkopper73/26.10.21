using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicSQLDemo.Models
{
    public class spSearchEmployees : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
