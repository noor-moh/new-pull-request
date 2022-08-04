namespace Employees.Models
{
    public class Sales : Employee, IManager
    {
        private readonly decimal target = 1000;
        private readonly decimal sales;

        public Sales(int id, decimal salary, decimal sales) : base(id, salary)
        {
            this.sales = sales;
        }

        public override decimal GetSalary() => sales > target ? base.Salary + (decimal)0.15 * sales : base.Salary;

        private Manager manager;
        public Employee Manager => manager;
        public void SetManager(Employee Manager)
        {
            this.manager = (Manager)Manager;
        }
    }
}
