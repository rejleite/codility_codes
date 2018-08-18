using System;
using Rotation.library;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {3, 8, 9, 7, 6};
            Console.Write("How many times? ");
            var K = Console.ReadLine();
            Rotation.library.Rotation rt = new Rotation.library.Rotation();
            var result = rt.Rotate(A, Convert.ToInt32(K));

            Console.Write("[");
            foreach (var item in result)
            {
                Console.Write(item + " ");    
            }
            Console.Write("]");

        }
    }
}
