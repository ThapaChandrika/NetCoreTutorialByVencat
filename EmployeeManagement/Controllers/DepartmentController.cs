using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("[controller]/[action]")]
    public class DepartmentController : Controller
    {
        public string List()
        {
            return "List() of department controller";
        }

        public string Details()
        {
            return "Details of department controller";
        }
    }
}