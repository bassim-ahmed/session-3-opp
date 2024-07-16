using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_opp.Binding
{
    public class Employee
    {
        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public Employee()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }

        public void GetEmployeeType()
        {
            Console.WriteLine("iam employee");
        }
        public virtual void GetEmployeeData()
        {
            Console.WriteLine($"employee id:{Id} ,name : {Name},age:{Age } ");
        }
    }
}
