using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace hackerran
{
    class Solution
    {

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            for (int a = n - 1; a >= 0; --a)
            {
                Console.Write(arr[a] + " ");
            }
        }
    }
}
