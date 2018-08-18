using System;

namespace BinaryGap.library
{
    /* A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded 
       by ones at both ends in the binary representation of N.
       For example:
        The number 9 has binary representation 1001 and contains a binary gap of length 2. 
        The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. 
        The number 20 has binary representation 10100 and contains one binary gap of length 1. 
        The number 15 has binary representation 1111 and has no binary gaps. 
        The number 32 has binary representation 100000 and has no binary gaps. */
    public class BinaryGap
    {
        public int GetBinaryGap (int N){
            string binary_str = Convert.ToString(N, 2);

            int longest_gap = 0;
            int size_gap = 0;
            bool begin_gap = false;

            for (int i = 0; i < binary_str.Length; i++)
            {
                
                if ((binary_str[i] == '1') && (i+1 < binary_str.Length) && (binary_str[i+1] == '0')){
                    begin_gap = true;
                    size_gap = 0;
                    continue;
                }
                
                if (begin_gap && binary_str[i] == '0'){
                    size_gap ++;
                }

                if (binary_str[i] == '0' && i+1 < binary_str.Length && binary_str[i+1] == '1')
                {
                    if (size_gap > longest_gap)
                    {
                        longest_gap = size_gap;
                    }
                    begin_gap = false;
                }

            }
            return longest_gap;
        }

    }
}
