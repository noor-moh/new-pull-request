using System;

namespace Employees.Models
{
    /// <summary>
    /// int id, double salary,double bonus
    /// </summary>
    public class Manager : Employee
    {
        private readonly decimal bonus;

        public Manager(int id, decimal salary, decimal bonus) : base(id, salary)
        {
            this.bonus = bonus;
        }

        public override decimal GetSalary() => base.Salary + bonus;

    }
}
