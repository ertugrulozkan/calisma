using System;

namespace CarpimTablosu
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("--------------");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} ={2}", i,j, i * j);
                }
            }
            Console.ReadLine();
        }
    }
}
