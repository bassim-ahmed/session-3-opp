using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_opp.polymorphism_overriding
{
    internal class TypeB :TypeA
    {
    

        public int B {  get; set; }
        public TypeB(int a,int b):base(a)
        {
            B = b;
        }
        //apply function ovrriding useing new keyword
        public new void MyFun01()
        {
            Console.WriteLine("this is a [child]");
        }
        // apply function using ovrride
        public override void MyFun02()
        {
            Console.WriteLine($"THIS IS MY B : A{A},B{B}");
        }

    }
}
