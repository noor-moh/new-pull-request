using System;

namespace Employees.Models
{
    public abstract class Employee
    {
        private readonly int id;
        private readonly decimal salary;

        public Employee(int id, decimal salary)
        {
            this.id = id;
            this.salary = salary;
        }

        public int Id => id;
        public decimal Salary => salary;

        public virtual decimal GetSalary() => salary;

    }
    public interface IManager
    {

        public Employee Manager { get; }
        public void SetManager(Employee Manager);
    }


}
