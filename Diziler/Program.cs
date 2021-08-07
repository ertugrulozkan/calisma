using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {   //string,char,imt,double


            /* string[] dizi = new string[4]; // bu şekilde dizi tanımlanabilir elemanları daha sonradan girilmek üzere
             string[] dizi2 = { "ali", "veli", "hasan", "erkan" }; // bu şekilde tanımladığında dizi eleman sayısını girmene gerek yok
                                                                   // 

             for (int i = 0; i <dizi2.Length; i++)
             {
                 Console.WriteLine("dizinin {0}.elemanı={1}", i + 1, dizi2[i]);
             }
             Console.WriteLine("----------------------------------------------");
             for (int i = 0; i < dizi.Length; i++)
             {
                 Console.WriteLine("dizinin" + (i + 1) + ".elemanını giriniz");
                 dizi[i] = Console.ReadLine();
             }

             for (int i = 0; i < dizi.Length; i++)
             {
                 Console.WriteLine("dizinin " + (i + 1) + ".elemanı {0}",dizi[i]);


             }

             foreach (var isim in dizi) //aynı diziyi foreach ile yazdırmak mümkün

             {
                 Console.WriteLine(isim);
             }*/

            // girilen sayı dizide varmı

            /*int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 17, 18, 19, 40, 20, 22, 21 };

             Console.WriteLine("dizide olduğunu düşündüğünüz sayıyı giriniz: ");
             int x = Convert.ToInt32(Console.ReadLine());
             int sonuc = 0;
             for (int i = 0; i <sayilar.Length; i++)
             {
                 if (x == sayilar[i])
                 {
                     sonuc = sayilar[i];
                     Console.WriteLine("girilen {0} sayısı dizide vardır", x);
                     break;
                 }

             }
             if (sonuc==0)
             {
                 Console.WriteLine("girilen {0} sayısı dizide yoktur", x);
             }
            */

            //10 elemanlı bir dizi alarak tek ve çift kontrolü yapmak 
            // bu tek ve çiftin adedini yazdırmak
            //tekler toplamı mı büyük çiftler toplamımı buna bakmak

            int[] sayilar = new int[10];
            int count1 = 0, count2 = 0, sum1 = 0, sum2 = 0;
            for (int i = 0; i <sayilar.Length; i++)
            {
                Console.WriteLine("sayılar dizisinin  {0}. elemanını giriniz:", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <sayilar.Length; i++)
            {
                if (sayilar[i]%2==0)
                {
                    count1++;
                    sum1 += sayilar[i];
                }

                if (sayilar[i] % 2 == 1)
                {
                    count2++;
                    sum2 += sayilar[i];
                }

            }
            Console.WriteLine("dizide {0} tane çift, {1} tane tek eleman var", count1, count2);
            Console.WriteLine("----------------");
            Console.WriteLine("dizideki çift sayıların toplamı{0}, tek sayıların toplamı{1} dir", sum1, sum2);
            Console.WriteLine("----------------");
            if (sum1<sum2)
            {
                Console.WriteLine("dizideki tek sayıların toplamı daha büyüktür");
            }
            else
            {
                Console.WriteLine("dizideki çift sayıların toplamı daha büyüktür");
            }

        }
    }
}
