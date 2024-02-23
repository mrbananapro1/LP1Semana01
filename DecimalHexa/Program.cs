using System;

namespace DecimalHexa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva quatro números");
            string n1 = Console.ReadLine();
            int i1 = int.Parse(n1);
            string n2 = Console.ReadLine();
            int i2 = int.Parse(n2);
            string n3 = Console.ReadLine();
            int i3 = int.Parse(n3);
            string n4 = Console.ReadLine();
            int i4 = int.Parse(n4);

            Console.WriteLine($"{i1,6:d} {i1,6:X}"  );
            Console.WriteLine($"{i2,6:d} {i2,6:X}"  );
            Console.WriteLine($"{i3,6:d} {i3,6:X}"  );
            Console.WriteLine($"{i4,6:d} {i4,6:X}"  );
            
        }
    }
}
