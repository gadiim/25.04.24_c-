using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClafeLibrary
{
    public class Employee
    {
        private string EmployeeName { get; set; }
        private string EmployeePosition { get; set; }

        public Employee(string name, string position)
        {
            EmployeeName = name;
            EmployeePosition = position;
        }

        public override string ToString()
        {
            return  $"name:\t\t{EmployeeName}\nposition:\t{EmployeePosition}\n";
        }
    }

    public class Cafe
    {
        private List<Employee> employees;

        public Cafe()
        {
            employees = new List<Employee>();
        }

        public void ToAddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return employees.GetEnumerator();
        }
    }
}
