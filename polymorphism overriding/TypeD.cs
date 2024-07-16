using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_opp.polymorphism_overriding
{
    internal class TypeD:TypeC
    {
        public int D {  get; set; }

        public TypeD(int a,int b,int c,int d):base(a,b,c)
        {
            D = d;
            
        }
        public new void MyFun01()
        {
            Console.WriteLine("this is a [GRAND grand child]");
        }
        //Myfun02 -- if (public-virtual)
        //1-new => end old sequence
        //2- virtual-start new sequence
        public new virtual void MyFun02()
        {
            Console.WriteLine($"THIS IS MY D :A{A},B{B}c{C}D{D}");
        }
    }

}
