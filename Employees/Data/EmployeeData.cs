using Employees.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Data
{
    public static class EmployeeData
    {
        public static IEnumerable<Employee> Employees => new List<Employee>
        {
            new Sales(1,1000,5000),
            new Sales(2,1000,500),
            new Manager(3,1000,200),
            new Manager(4,1000,250),
            new Manager(5,1000,300),
            new LeadDeveloper(6,1200),
            new LeadDeveloper(7,700),
            new Developer(8,900),
            new Developer(9,450),
            new Developer(10,2000),
            new HumanResources(11,1500),
            new HumanResources(12,880),
            new HumanResources(13,900),

        };
    }
}
