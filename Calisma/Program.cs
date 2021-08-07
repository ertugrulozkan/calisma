using System;

namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            int hakSayisi = 3;
            while (true)
            {
                Console.WriteLine("kullanıcı adınızı giriniz:");
                string KullaniciAdi = Console.ReadLine();

                Console.WriteLine("kullanıcı şifrenizi giriniz:");
                string KullaniciSifre = Console.ReadLine();

                if (KullaniciAdi=="ertugrul" && KullaniciSifre=="123")
                {
                    Console.WriteLine("tebrikler doğru firiş yaptınız.");
                    break;
                }

                else
                {
                    Console.WriteLine("yanlış kullanıcı adı ya da şifre girdiniz");
                    if (hakSayisi>0)
                    {
                        hakSayisi--;
                    }
                    if (hakSayisi==0)
                    {
                        Console.WriteLine("3defa yanlış girdiniz hakkınız bitti");
                        break;
                    }
                }
            }
        }
    }
}
