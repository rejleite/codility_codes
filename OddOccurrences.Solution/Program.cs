using System;
using System.Collections;

namespace TestSolution
{
    public class Occurrences
    {
        public int FindUnpaired(int[] A)
        {   
            HashSet<int> unpaired = new HashSet<int>();

            foreach (var i in A)
            {
                if(unpaired.Contains(i)){
                    unpaired.Remove(i);
                }else
                {
                    unpaired.Add(i);
                }
            } 

/*             int result = 0;
            foreach (var i in A)
                result ^= i;                      
 */
            return unpaired.First(); //result;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {9, 3, 9, 3, 9, 9, 3};
            Occurrences oc = new Occurrences();
            var result = oc.FindUnpaired(A);
            Console.Write(result);

        }
    }
}
