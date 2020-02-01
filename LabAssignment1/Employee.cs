using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    public class Employee
    {
        public string name;
        public double salary;
        public double salaryId;

        public Employee(string name, double salary, double salaryId)
        {
            this.name = name;
            this.salary = salary;
            this.salaryId = salaryId;
        }
        public string GetName()
        {
            return name;
        }
        public double GetSalary()
        {
            return salary;
        }
        public double GetSalaryId()
        {
            return salaryId;
        }

        public virtual void SalaryCalculator()
        {

        }
    }
}


