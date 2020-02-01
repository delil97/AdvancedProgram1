using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment1
{
  public class Company
    {
        string name;    
        public Company(List<Employee> empLista, string name) 
        {
            this.name = name;
            empLista = new List<Employee>();
        }
        public void addEmployee(List<Employee> empLista, Employee emp)
        {
            empLista.Add(emp);
        }
    }
}