using System;

namespace the_ordener
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int [] { 2, 1, 4, 3, 1, 45, 9 };
            foreach (int valor in lista)
            {
                Console.Write($"{valor} ");

            }
            Console.ReadLine();

            

        }
    }
}
