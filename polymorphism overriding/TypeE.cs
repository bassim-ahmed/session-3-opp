using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_opp.polymorphism_overriding
{
    internal class TypeE:TypeD
    {
        public int E {  get; set; }
        public TypeE(int a,int b,int c,int d,int e):base(a,b,c,d)
        {
            E = e;
            
        }
        public new void MyFun01()
        {
            Console.WriteLine("this is a [GRAND grand grand child]");
        }
        //in type d myfun2 public new =>you can not overriding using key override
        //in type d myfun2 public new virtual =>you can overriding using key override
        public override void MyFun02()
        {
            Console.WriteLine($"THIS IS MY D :A{A},B{B}c{C}D{D}E{E}");
        }
    }
}
