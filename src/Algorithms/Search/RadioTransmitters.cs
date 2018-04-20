using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Search
{
    // Challenge: https://www.hackerrank.com/challenges/hackerland-radio-transmitters/problem
    public class RadioTransmitters
    {
        public static int Resolve(int[] houses, int transmitterRange) 
        {
            Array.Sort(houses);

            int numOfTransmitters = 0;
            int i = 0;
            int n = houses.Length;

            while (i < n) {
                numOfTransmitters++;
                int loc = houses[i] + transmitterRange;
                while (i < n && houses[i] <= loc) i++;
                loc = houses[--i] + transmitterRange;
                while (i < n && houses[i] <= loc) i++;
            }
            
            return numOfTransmitters;
        }
    }
}
