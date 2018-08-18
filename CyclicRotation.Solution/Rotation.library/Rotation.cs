using System;

namespace Rotation.library
{
    public class Rotation
    {
        public int[] Rotate(int[] A, int K)
        {   
            var size = A.Length;
            int[] rotated = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                rotated[(i+K)%size] = A[i];
            }

            return rotated;

        }
    }
}

