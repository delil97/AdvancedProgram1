using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
   public class ProgramLeader : Programers
    {
        string ans;
        double total;
        string ments;

        public List<Programers> mentorList = new List<Programers>();
        public ProgramLeader(string name, double salary, double salaryId, string language, List<Programers> mentorList)
            : base(name, salary, salaryId, language)
        {

            mentorList = new List<Programers>();
        }
        public string GetMentees()
        {
            foreach (var item in mentorList)
            {
                ans = item.GetName();
            }
            return ans;

        }
        public string GetMentor()
        {
            foreach (var item in mentorList)
            {
                ments = item.GetName();

            }
            return ments;
        }
        public override void SalaryCalculator() // Calculates the salary with 5%
        {
            base.SalaryCalculator(); 
            total = mentorList.Count;

            double mentorEnhancement = ((salary * 0.05) * (total)); // Here we add 5% to the salary if someone is mentor
            salary += mentorEnhancement;

        }    
    }
}
