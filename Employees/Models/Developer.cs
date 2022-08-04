using System;

namespace Employees.Models
{
    public class Developer : Employee, IManager
    {
        public Developer(int id, decimal salary) : base(id, salary)
        {
        }
        private LeadDeveloper manager;
        public Employee Manager => (LeadDeveloper)manager;

        public void SetManager(Employee Manager)
        {
            this.manager = (LeadDeveloper)Manager;
        }
    }
}
