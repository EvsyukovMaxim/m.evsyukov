﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            string x = Console.ReadLine();
            //int[] Calculator = new int[a];
            switch (x == "+")
            {
                case:
                    int z = a + b;
                    Console.WriteLine(z);
                    break;
            }
        }
    }
}