using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w6___s2___p7
{

    #region 1
    //enum Grades
    //{
    //    A,B,C,D,E,F
    //}
    //enum Gender
    //{
    //    Male,Female 
    //}
    #endregion

    [Flags]
    enum Permission : byte
    {
          Delete = 1,
          Excute = 2,
          Write = 4,
          Read = 8
    }







    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //Grades G01 = Grades.D;
            //G01 = (Grades)3;
            #endregion






            //Permission P01 = Permission.Delete;
            //P01 ^= Permission.Excute;
            //P01 |= Permission.Write;
            //P01 |= Permission.Read;
            //Console.WriteLine(P01);

            //P01 ^= Permission.Excute;
            //Console.WriteLine(P01);

            //if((P01 & Permission.Read) == Permission.Read)
            //    Console.WriteLine("Permission Exist");
            //else
            //    Console.WriteLine("Permission Not Exist");

            //byte x = (byte)Permission.Read;
            //Console.WriteLine(x);




            Permission P02 = (Permission)15;
            Console.WriteLine(P02);

            P02 = (Permission)18;
            Console.WriteLine(P02);

        }
    }
}
