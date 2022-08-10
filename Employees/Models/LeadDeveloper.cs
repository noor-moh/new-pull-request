namespace Employees.Models
{
    public class LeadDeveloper : Employee, IManager
    {
        /// <summary>
        /// int id, double salary 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        public LeadDeveloper(int id, decimal salary) : base(id, salary)
        {
        }

        private Manager manager;
        public Employee Manager => manager;
        public void SetManager(Employee Manager)
        {
            this.manager = (Manager)Manager;
        }
    }
}
