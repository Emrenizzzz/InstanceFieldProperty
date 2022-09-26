using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceFieldProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Söz dizimi
            // class SinifAdi
            /* {
             *        [Erişim Belirleyici] [Veri Tipi] ozellikAdi;
             *        [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
             *        {
             *              Metot Komutları
             *        }
             *  } */

            //Erişim Belirleyiciler
            /* Public
             * Private
             * Protected
             * Internal */


            Calisan calisan1 = new Calisan();
            calisan1.Adi = "Yunus";
            calisan1.Soyadi = "Başer";
            calisan1.No = 10412345;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();

            Console.WriteLine("*****************");

            Calisan calisan2 = new Calisan();
            calisan2.Adi = "Emre";
            calisan2.Soyadi = "Sırakaya";
            calisan2.No = 12345678;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();
        }

        class Calisan
        {
            public string Adi, Soyadi, Departman;
            public int No;

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışanın Adı: {0}",Adi);
                Console.WriteLine("Çalışanın Soyadı: {0}",Soyadi);
                Console.WriteLine("Çalışanın numarası: {0}",No);
                Console.WriteLine("Çalışanın departmanı: {0}",Departman);
            }
        }
    }
}
