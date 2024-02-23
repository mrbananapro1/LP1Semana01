using System;
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



            string cct = $"a"+ "2";
            Console.WriteLine(cct);
            string LF = $"\u24C1" + "\u24BA" + "\u24C4";
            Console.WriteLine(LF);
            string x = "Run";
            string y = "Away";
            Console.WriteLine($"{x} {y}");
        }
    }
}
