using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
    public class Programers: Employee
    {      
        public string language;
        public ProgramLeader mentor { get; set; }
           public Programers(string name, double salary, double salaryId, string language)
                :base(name, salary, salaryId)
            {   
                this.language = language;
                mentor = null;
            }
        public override void SalaryCalculator() 
// I decided to do an if funcition because I think its the best solution to add a 10% bonus to the salary, so if the employee has java as programing language he gets a 10% bonus, salary * 1.1.
        {          
              if (language.ToUpper() == "JAVA")
                {
                    salary = salary * 1.1;
                }

        }
        //public void addMentee(List<Programers> menteeList, Programers m)
        //{
        //    menteeList.Add(m);
        //}
        public string GetLanguage()
        {
            return language;
        }
        public virtual double mentorCalculater() // overide
        {
            return salary;
        }
    }   
}



