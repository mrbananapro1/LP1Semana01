﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace ManyStrings
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            string L1 = "\u24C1";
            Console.WriteLine(L1);
            string L2 = "\u24BA";
            Console.WriteLine(L2);
            string L3 = "\u24C4";
            Console.WriteLine(L3);
            double xx = 1.23456;
            int ii = 19;

            string cct = $"a"+ "2";
            Console.WriteLine(cct);
            string LF = $"\u24C1" + "\u24BA" + "\u24C4";
            Console.WriteLine(LF);
            string x = "Run";
            string y = "Away";
            Console.WriteLine($"{x} {y}");



            string x6 = $"{xx:f2}";
            Console.WriteLine(x6);
            string x7 = $"{xx:p}";
            Console.WriteLine(x7);

            string x8 = $"{ii:x}";
            Console.WriteLine(x8);
            string x9 = $"{ii:c}";
            Console.WriteLine(x9);

        }
    }
}
