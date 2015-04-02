﻿/*
 * Employees are humans with more charateristics
 */

namespace TaskManager.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using User.Interfaces;

    public class Employee : Person, IEmployee
    {

        private decimal salary;

        public int TimeWorked { get; private set; }
        public string Position { get; private set; }

        public Employee(string name, DateTime dateBirth, Gender sex, string position, int timeWorked, decimal salary)
            :base (name, dateBirth, sex)
        {
            this.Position = position;
            this.TimeWorked = timeWorked;
            this.Salary = salary;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                if (value < 900)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be less than 900 BGN");
                }
                this.salary = value;
            }
        }
        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendLine(string.Format("Position: {0}, Salary: {1}, Time Worked: {2}", this.Position, this.Salary, this.TimeWorked));
            return result.ToString();
        }
    }
}
