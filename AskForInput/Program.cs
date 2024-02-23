using System;
using System.Linq.Expressions;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve");
            string escreve = Console.ReadLine();
            int escreve1 = int.Parse(escreve);

            Console.WriteLine("Escreve");
            string escreve2 = Console.ReadLine();
            float escreve3 = float.Parse(escreve2);

            Console.WriteLine($"{escreve1 + escreve3}");

        }
    }
}
