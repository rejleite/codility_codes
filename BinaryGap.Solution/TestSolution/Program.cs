using System;
using BinaryGap.library;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inform a number:");
            var value = Console.ReadLine();
            BinaryGap.library.BinaryGap bg = new BinaryGap.library.BinaryGap();
            var result = bg.GetBinaryGap(Convert.ToInt32(value));

            Console.WriteLine("The binary gap of " + Convert.ToString(value) + " is " + Convert.ToString(result) );
        }
    }
}
