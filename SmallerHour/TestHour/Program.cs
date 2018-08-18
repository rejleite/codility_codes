using System;
using CalculateHour;

namespace TestHour
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B,C,D,E,F;
            //A=2;B=4;C=5;D=9;E=5;F=9;
            //A=2;B=3;C=5;D=3;E=1;F=9;
            //A=B=C=0;D=7;E=8;F=9;
            //A=B=C=0;D=2;E=3;F=4;
            //A=B=C=D=E=F=0;
            A=1;B=8;C=3;D=2;E=6;F=4;

            Time t = new Time();

            var result = t.CalculateMinTime(A, B, C, D, E, F);
            Console.WriteLine(result);
        }
    }
}
