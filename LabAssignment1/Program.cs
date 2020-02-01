using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{  
    
    class Program
    {     
        static void Main(string[] args)
        {
            // Using a delegate from firstDelegate class
            firstDelegate testdelegate = new firstDelegate();
            firstDelegate.MyDelegate fd1 = new firstDelegate.MyDelegate(testdelegate.fun1);
            fd1();
           
            Console.ReadKey();
            Console.Clear();

            // Createing a list called "mentorList". The reason Lists<> are used in this lab is because it is easier to sort data in them and use them, with lists it becomes less complicated to check the data.
            List<Programers> mentorList = new List<Programers>();

            // Employees of the Software Company
            Programers p1 = new Programers("Anders", 30000, 1, "Java");
            Programers p2 = new Programers("Johan", 30000, 2, "Java");
            Programers p3 = new Programers("Sven", 30000, 3, "Java");
            Programers p4 = new Programers("Johanna", 30000, 4, "React");
          
            //Programleaders, mentors
            ProgramLeader pl1 = new ProgramLeader("Josh", 30000, 5, "Java", mentorList);
            mentorList.Add(pl1);

            ProgramLeader pl2 = new ProgramLeader("Erik", 30000, 6, "C#", mentorList);
            mentorList.Add(pl2);


            // pl2 is mentor to p3
            // pl1 is mentor to p2
            pl2.mentorList.Add(p3);
            pl1.mentorList.Add(p2);

            // p3 is mentee for pl2
            // p2 is mentee for pl1
            p3.mentor = pl2;
            p2.mentor = pl1;
   
            // Here we can see the mentees
            List<Programers> menteeList = new List<Programers>();
            menteeList.Add(p1);
            menteeList.Add(p2);
            menteeList.Add(p3);
            menteeList.Add(p4);

            List<Employee> empLista = new List<Employee>();

            // In this list we can find all the employees of the company, mentees and mentors etc..
            Company s1 = new Company(empLista, "Computer Dellics");
            s1.addEmployee(empLista, p1);
            s1.addEmployee(empLista, p2);
            s1.addEmployee(empLista, p3);
            s1.addEmployee(empLista, p4);
            s1.addEmployee(empLista, pl1);
            s1.addEmployee(empLista, pl2);
        
            for (var i = 0; i < menteeList.Count; i++)
            {
              menteeList[i].SalaryCalculator(); 
            }

            foreach (var mentor in mentorList)
            {
                mentor.SalaryCalculator();
            }
            Console.WriteLine("Employees:");
            foreach (var item in menteeList)
            {
                try // try catch, 
                {               
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Name: " + item.GetName());
                    Console.WriteLine("Salary: " + item.GetSalary());
                    Console.WriteLine("Salary Id: " + item.GetSalaryId());
                    Console.WriteLine("Language: " + item.GetLanguage());

                    if (item.GetType() == typeof(Programers))
                    {
                        Programers programmerare = (Programers)item;
                        if(programmerare.mentor != null)
                        { 
                            Console.WriteLine("Mentor: " + programmerare.mentor.name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Something went wrong!"); // this message will be shown in case something wents wrong
                }
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Programleaders:");

            foreach (var item in mentorList)
            {
                try // try catch
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Name: " + item.GetName());
                    Console.WriteLine("Salary: " + item.GetSalary());
                    Console.WriteLine("Salary Id: " + item.GetSalaryId());
                    Console.WriteLine("Language: " + item.GetLanguage());

                    if (item.GetType() == typeof(ProgramLeader))
                    {
                        ProgramLeader pLeader = (ProgramLeader)item;
                        Console.WriteLine("Mentee: " + pLeader.GetMentees());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Something went wrong!");
                }        
            }
            double totalSalaryOfTheCompany = 0; // with this function helps us to sum the total amount of money that all the employees gets every month.
            foreach (var allSalary in empLista)
            {
                totalSalaryOfTheCompany = totalSalaryOfTheCompany + allSalary.GetSalary();
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Monthly cost of the company: " + totalSalaryOfTheCompany ); 
        }
    }
}
