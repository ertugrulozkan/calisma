using System;

namespace GirilenSayiyaKadarTopla
{
    class Program
    {
        static void Main(string[] args)
        { int toplam = 0;
            Console.WriteLine("bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayi = int.Parse(Console.ReadLine());  bu kod da işe yarar
            for (int i =1; i <=sayi; i++)
            {
                toplam += i;
            }
            Console.WriteLine("toplam=" + toplam);

            Console.ReadLine();
        }
    }
}
