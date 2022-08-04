namespace Employees.Models
{
    public class HumanResources : Employee, IManager
    {
        public HumanResources(int id, decimal salary) : base(id, salary)
        {
        }
        private  Manager manager;
        public Employee Manager => manager;

        public void SetManager(Employee Manager)
        {
            manager = (Manager)Manager;
        }
    }
}
