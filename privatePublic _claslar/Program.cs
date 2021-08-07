using System;

namespace privatePublic__claslar
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci(1,"erkan","özkan",50,80,60,"çpl");
            Console.WriteLine("uygulamamıza hoşgeldiniz");
           
            
            bool kontrol = true;
            while (kontrol)
            {
                islemleriGoster();
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        ogr1.ogrenciBilgileriGoster();
                        break;
                    case "2":
                      double ogrOrtalam=  ogr1.ogrenciortalamasi();
                        Console.WriteLine("oğrenci ortalaması =" + ogrOrtalam);
                        break;
                    case "3":
                        ogr1.okulgetir();
                        break;
                    case "4":
                        kontrol = false;
                        break;
                }
            }
        }
        static void islemleriGoster()
        {
            Console.WriteLine("1 öğrenci bilgilerini göster");
            Console.WriteLine("2 öğrenci ortalamasını göster");
            Console.WriteLine("3 öğrenci okulunu göster");
            Console.WriteLine("4 çıkış yap");
        }
    }
}
