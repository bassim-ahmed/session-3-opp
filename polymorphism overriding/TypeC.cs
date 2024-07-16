using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_opp.polymorphism_overriding
{
    internal class TypeC:TypeB
    {
        //tYPE C =>Direct parent {Type b}
        //Type c =>Indirct parent {Type a}
        public int C {  get; set; }
        public TypeC(int a,int b,int c):base(a,b)
        {
            C = c;
            
        }
        public new void MyFun01()
        {
            Console.WriteLine("this is a [GRAND child]");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"THIS IS MY C :A{A},B{B}c{C}");
        }
    }
}
