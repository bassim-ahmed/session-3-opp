using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_opp.polymorphism_overriding
{
    internal class TypeA
    {
    

        public int A {  get; set; }
        public TypeA(int a)
        {
            A = a;
        }
        public void MyFun01()
        {
            Console.WriteLine($"IAM bASE [pARNT]");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"THIS IS MY A :{A}");
        }

    }
}
