using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_opp.Binding
{
    public class FulltimeEmployee :Employee
    {
      

        public decimal Salary { get; set; }
        public FulltimeEmployee(int id,string name,int age, decimal salary):base( id,name,age)
        {

            Salary = salary;
        }

        public new void GetEmployeeType()
        {
            Console.WriteLine("this is fulltime employee");
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($"fulltime employee id:{Id} ,name : {Name},age:{Age},salary:{Salary}");
        }
    }

}
