
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public static List<Manager> Managers = new List<Manager> {

            new Manager { Id = 1, Name = "Manage"},
            new Manager { Id = 2, Name = "MG"}
        };

        public static List<Employee> Employees = new List<Employee> {

            new Employee { Id = 1,
                FirstName = "Kaushalya",
                LastName = "Priyawandika",
                Age = 25,
                Manager = Managers[0]
            },
           new Employee { Id = 2,
                FirstName = "Nimali",
                LastName = "Herath",
                Age = 28,
                Manager = Managers[1]
            },
        };


        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetEmployee()
        {
            return Ok(Employees);
        }

        [HttpGet("id")]
        
        public async Task<ActionResult<Employee>> GetSingleEmployees(int id)
        {
            var Emp = Employees.FirstOrDefault(h =>h.Id == id);
            if (Emp == null)
            {
                return NotFound("Sorry, no emp here. :/");
            }
            return Ok(Emp);
        }
    }
}
