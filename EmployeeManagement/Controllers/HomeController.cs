using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
   
    [Route("Home")]
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [Route("/")]
        [Route("")]
        [Route("Index")]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }

        [Route("Details/{id?}")]
        public ViewResult Details(int? id)
        {
            //Employee model = _employeeRepository.GetEmployee(1);
            //ViewBag.PageTitle = "Employee Details";
            ////ViewBag.Employee = model;
            ////ViewData["PageTitle"] = "Employee Details";
            ////ViewData["Employee"] = model;
            //return View(model);

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id ?? 1),
                PageTitle = "Employee Details"
            };

            return View(homeDetailsViewModel);
        }
    }
}