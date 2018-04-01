using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;


namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly List<EmployeeView> _employeesView = new List<EmployeeView>
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
            return View(_employeesView);
        }

        public IActionResult Details(int id)
        {
            var employee = _employeesView.FirstOrDefault(t => t.Id == id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }
    }
}