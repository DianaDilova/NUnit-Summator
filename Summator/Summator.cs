using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static double Average(double[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum/arr.LongLength;
        }
        public static double Multiply(double[] arr)
        {
            if (arr.Length == 0) return 0;
            double sum = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                sum *= arr[i];
            }
            return sum;
        }
        
    }
}
