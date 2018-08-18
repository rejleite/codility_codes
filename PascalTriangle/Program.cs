/*	
On the sequence of logical values (true or false) we can build up an OR-Pascal-triangle structure. Instead of summing the values, as in a standard Pascal-triangle, we will combine them using the OR function. That means that the lowest row is simply the input sequence, and every entry in each subsequent row is the OR of the two elements below it. For example, the OR-Pascal-triangle built on the array [true, false, false, true, false] is as follows:

				true
			true	true
		true	true	true	
	true 	false 	true	true	
true	false	false	true	false

Your job is to count the number of nodes in the OR-Pascal-triangle that contain the value true (this number is 11 for the triangle above).

Write a function:

class Solution { public int solution(bool[] P); }

that, given an array P of N Booleans, returns the number of fields in the OR-Pascal-triangle built on P that contain the value true. If the result is greater than 1,000,000,000, your function should return 1,000,000,000.

Given P = [true, false, false, true, false], the function should return 11, as explained above.

Given P = [true, false, false, true], the function should return 7, as can be seen in the triangle below.

			true
		true	true
	true	false	true
true	false	false	true


Assume that:

N is an integer within the range [1..100,000].
Complexity:

expected worst-case time complexity is O(N);
expected worst-case space complexity is O(1) (not counting the storage required for input arguments). 
*/
using System;

namespace PascalTriangle
{
    class TrueValuesPascalTriangle
    {
        public int CalculateTrueValues(bool[] P){

            long row_size = P.Length;
            long total = (row_size * (row_size+1)) / 2;
            var n = 0;
            var hasFalse = false;

            var total_false = 0;
            while(n < row_size)
            {
                hasFalse = false;
                for (int i = 0; i < (row_size-n); i++)
                {
                    if(!P[i])
                        hasFalse = true;
                    total_false += Convert.ToInt32(!P[i]);

                    if ( i + 1 < (P.Length-n) )
                        P[i] = (P[i]|P[i+1]);
                }

                if (!hasFalse)
                    break;
                n++;
            }

            if (total_false > 0)
                total = total - total_false;

            if (total >= 1000000000)
                total = 1000000000;

            return (int)total;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool[] test = new bool[] { true, true, true ,true, true, true};
            //{true, false, false, true};
            /*{true, true, false, false, true, true, false, false, true, false, true, true, false, false,true, true, false, false,true, true, false, false,true, true, false, false,true, true, false, false,true, true, false, false,
            true, false, false, true, true, false, false, true, false, true, true, false, false,true, true, false, false,true, true, false, false,true, true, false, false,true, true, false, false,true, true, false, false,
            true, false, false, true, true, false, false, true, false, true, true, false, false,true, true, false, false,true, true, false, false,true, true, false, false,true, true, false, false,true, true, false, false};
            */
            //{ true, false, false, true, false, true};
            //;

            TrueValuesPascalTriangle p = new TrueValuesPascalTriangle();
            Console.WriteLine(test.Length);
            var result = p.CalculateTrueValues(test);

            Console.WriteLine(result);
        }
    }
}
