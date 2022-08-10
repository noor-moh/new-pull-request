using Employees.Data;
using Employees.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Controllers
{
    /// <summary>
    ///  Employees Controller
    /// </summary>
    [Route("api/v1/developer")]
    [Produces("application/json")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// Calculate Developers salary : double
        /// </summary>
        /// <param name="Id">: int</param>
        /// <returns>salary value</returns>
        [HttpGet("calculate-salary")]
        public decimal CalculateSalary([FromQuery] int Id)
        {
            return EmployeeData.Employees.FirstOrDefault(x => x.Id == Id).Salary;
        }

        /// <summary>
        /// </summary>
        /// <param name="managerId ">  </param>
        /// <param name="employeeId"></param>
        [HttpPost("set-manager")]
        public void SetEmployeeManager([FromQuery] int managerId, [FromQuery] int employeeId)
        {
            var manager = EmployeeData.Employees.FirstOrDefault(x => x.Id == managerId);
            var employee = (Developer)EmployeeData.Employees.FirstOrDefault(x => x.Id == employeeId);
            employee.SetManager((LeadDeveloper)manager);
        }
    }
}
