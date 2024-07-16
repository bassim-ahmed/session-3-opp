using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_opp.Binding
{
    internal class ParttimEmployee:Employee
    {
        public int CountOfHours {  get; set; }
        public decimal HourRate {  get; set; }

        public new void GetEmployeeType()
        {
            Console.WriteLine("iam parttime employee");
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($"parttime employee id:{Id} ,name : {Name},age:{Age},CountOfHours:{CountOfHours},HourRate:{HourRate}");
        }

    }
}
