using System;
using System.Collections.Generic;

namespace DataStructures.Arrays
{
    // Challenge: https://www.hackerrank.com/challenges/arrays-ds/problem
    public class ArraysDS
    {
        public static int[] Resolve(int length, int[] a) 
        {
            int maxIndex = length - 1;
            int[] reverse = new int[length];

            for (int i = maxIndex, j = 0; i >= 0; i--, j++)
            {
                reverse[j] = a[i];
            }

            return reverse;
        }
    }
}
