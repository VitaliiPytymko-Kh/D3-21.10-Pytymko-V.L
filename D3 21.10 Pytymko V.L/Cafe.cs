using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_21._10_Pytymko_V.L
{
    public class Cafe:IEnumerable<Employee>
    {private List<Employee> _employees;
        public Cafe() 
        {
        _employees = new List<Employee>();
        }
        public void Addemployee(string name, string speciality)
        {
            Employee emp = new Employee(name, speciality); 
            _employees.Add(emp);
        
        }
        public IEnumerator<Employee> GetEnumerator() 
        {foreach (var emp in _employees) 
            { yield return emp; }
        }
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); } 

    }
    public class Employee 
    {
        public string _Name { get; set; }
        public string _Speciality { get; set; }

        public Employee( string name,string speciality) 
        {
        _Name = name;   
            _Speciality = speciality;
        
        }
    }
}
