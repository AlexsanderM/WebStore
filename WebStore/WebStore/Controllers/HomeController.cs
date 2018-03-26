using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeView> _employeeView = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "Sasha",
                SurName = "Petrov",
                Patronymic = "Vladimirovich",
                Age = 22
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Aaa",
                SurName = "Bbbb",
                Patronymic = "Cccc",
                Age = 5
            }
        };
        public IActionResult Index()
        {
            return View(_employeeView);
        }

        public IActionResult Details()
        {
            return View(_employeeView);
        }
    }
}