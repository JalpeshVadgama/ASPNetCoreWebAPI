using System.Collections.Generic;
using CoreWebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
           var employees = new List<Employee>
           {
               new Employee {EmployeeId = 1,FirstName = "Jalpesh",LastName = "Vadgama",Designation = "Technical Architect"},
               new Employee {EmployeeId = 2,FirstName = "Vishal",LastName = "Vadgama",Designation = "Technical Lead"}
           };
            return employees;
        }
    }
}
