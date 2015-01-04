﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_25
{
    class Program
    {
        public static bool UpOrder(int[] arr, int n)
        {
            if (n == 2||n==1)
            {
                return true;
            }
            else
            {
                if (arr[n - 1] - arr[n - 2] == arr[n - 2] - arr[n - 3])
                    return UpOrder(arr, n - 1);
                else
                    return false;
            }
        }
        public static bool UpOrder(int[] arr)
        {
            int x = arr.Length;
            return UpOrder(arr, x);
        }


        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10 };
            Console.WriteLine(UpOrder(arr));
        }
    }
}

