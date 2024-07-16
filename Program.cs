using session_3_opp.Binding;
using session_3_opp.polymorphism_overriding;
using System.Security;

namespace session_3_opp
{

    
    public class Program
    {
        //Employee employee
        //can refer =>employee
        //can refer =>object from class inhert from object employee 

        public static void Processemployee(Employee employee)
        {
            if (employee is not null)
            {
                employee.GetEmployeeType();
                employee.GetEmployeeData();
            }
        }

        #region overloading
        public static int Sum(int x,int y)
        {
            return x + y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static int sum(int x, int y, int z)
        {
            return x + y + z;
        }
        #endregion
        static void Main(string[] args)
        {
            #region overloading
            double result = Sum(2.2, 5.56);
            Console.WriteLine(result);
            int result1 = Sum(2, 5);
            Console.WriteLine(result1);
            #endregion
            #region overriding
            TypeA typeA =new TypeA(1);
            Console.WriteLine(typeA.A);
            typeA.MyFun01();
            typeA.MyFun02();
            Console.WriteLine("===================================");
            TypeB typeB = new TypeB(1, 2);
            typeB.A = 20;
            typeB.B = 34;
            typeB.MyFun01();
            typeB.MyFun02();
            #endregion
            #region binding
            TypeA refbase;
            ///dclare fore rfernce from type a
            ///refbase refer to an object from type a
            ///or refer  to an object from any class [inherit from type a]
            refbase=new TypeB(1, 2);
            refbase.A = 20;//VALID BC A INSIDE TYPE A
            //refbase.B=23 //invalid bc b isnot inside type a
            Console.WriteLine("--------------------------------------------");
            refbase.MyFun01();//IAM bASE [pARNT]
            refbase.MyFun02();//THIS IS MY B :2

            #endregion
            #region not binding
            //ref from child =>object from parent
            //TypeB Childrf= new TypeA(1, 2);//INVALID
            //TypeB Childref= (TypeB) new TypeA(1);//not binding
            //explicit casting
            //unsafe casting
            //TypeA typeA1 = new TypeA(1);
            //TypeB typeB1 = (TypeB)typeA1;//explicit casting
            //Console.WriteLine(typeB1.A); //invalid 
            //Console.WriteLine(typeB1.B);//invalid
            TypeA typea= new TypeB(1,2);
            TypeB typeb = (TypeB)typea;
            Console.WriteLine(typeb.A);
            Console.WriteLine(typeb.B);


            #endregion
            #region binding ex 1
            //FulltimeEmployee fulltime = new FulltimeEmployee(6, "bassim", 25, 5000);
            //Processemployee(fulltime);
            ParttimEmployee parttimEmployee = new ParttimEmployee()
            {
                Id = 1,
                Name = "ahmed",
                Age = 25,
                CountOfHours = 10,
                HourRate=5.5m
            };
            ////parttimEmployee.Id= 1;
            ////parttimEmployee.Name = "ahmed";
            ////parttimEmployee.Age = 25;
            ////parttimEmployee.CountOfHours = 8;
            ////parttimEmployee.HourRate = 5.5m;

            Processemployee(parttimEmployee);
            #endregion
            #region binding ex 2
            //TypeA typeA2= new TypeC(1,2,3);
            //typeA2.A = 20;
            ////typeA2.B=23// invalid
            ////typeA2.C = 23;//INVALID
            //typeA2.MyFun01();//STATIC BINDING
            //typeA2.MyFun02();//DYNAMIC BINDING
            //TypeB TypeB2=new TypeC(1, 2,4);
            //TypeB2.A = 20;
            //TypeB2.B = 20;
            ////TypeB2.C = 37;//invalid
            //TypeB2.MyFun01();//static binding
            //TypeB2.MyFun02();//dynamic binding

            //-------------------------------------------------------------------------------
            TypeA typea1=new TypeE(1,2,3,4,5);//indirect parent
            TypeB typeb1 = new TypeE(1, 2, 3, 4, 5);//indirect parent
            TypeC typec1 = new TypeE(1, 2, 3, 4, 5);//indirect parent

            typea1.MyFun02();
            typeb1.MyFun02();
            typec1.MyFun02();
            //THIS IS MY C :A1,B2c3
            //Last override of my fun 02 =>was in type c
            //type d=>new virtual
            //-------------------------------------------------------------------------------
            TypeD Tyoed1 = new TypeE(1, 2, 3, 4, 5);
            Tyoed1.MyFun02();
            //THIS IS MY D :A1,B2c3D4E5
            //Dynamic binding
            //last override myfun02 in class typeE 


            #endregion
        }
    }
}
