using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privatePublic__claslar
{
    class Ogrenci
    {
        private int ogrNo;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;

        public Ogrenci(int _ogrNo,string _isim, string _soyisim, int _vize1,int _vize2,int _final, string _okulIsmi)
        {
            ogrNo = _ogrNo;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsmi = _okulIsmi;
        }

        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("öğrenci numarası:" + ogrNo);
            Console.WriteLine("öğrenci ismi soy ismi: {0} {1}",isim,soyisim);
            Console.WriteLine("öğrenci 1. vizesi:" + vize1);
            Console.WriteLine("öğrenci 2. vizesi:" + vize2);
            Console.WriteLine("öğrenci finali" + final);
            Console.WriteLine("öğrenci okulu:" + okulIsmi);

        }
        public double ogrenciortalamasi()
        {
            double ortalama = vize1 * 0.3 + vize2 * 0.3 + final * 0.4;
            return ortalama;
        }
        public void okulgetir()
        {
            Console.WriteLine("öğrenci okulu: " + okulIsmi);
        }
    }
}
