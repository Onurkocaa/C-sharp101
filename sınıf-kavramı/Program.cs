using System;

namespace sınıf_kavramı
{
    class Program
     {
        static void Main (string[] args)
        {
            //Söz Dizimi
            //Class SınıfAdı
            //{
            //    [Erişim Belirleyici] [Veri Tipi] ÖzellikAdı:
            // [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdı([Parametre Listesi])
            //  {
            //   Metot Komutları
            //  }
            //}

            //Erişim Belirleyiciler
            //* Public
            //* Private
            //* Internal
            //* Protected
            Calisan calisan1 = new Calisan();
            calisan1.Ad="Onur";
            calisan1.Soyad="Koca";
            calisan1.No=123214664;
            calisan1.Departman="İnsan Kaynakları";
            calisan1.CalisanBilgileri();
            Console.WriteLine("************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Ali";
            calisan2.Soyad="Veli";
            calisan2.No=15234123;
            calisan2.Departman="Satın Alma";
            
            calisan2.CalisanBilgileri();
        }
     }
     
     class Calisan
     {
         public string Ad;
         public string Soyad;
         public int No;
         public string Departman;

         public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışan Adı:{0}",Ad);
                Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
                Console.WriteLine("Çalışan Numarası:{0}",No);
                Console.WriteLine("Çalışan Departmanı:{0}",Departman);
                
            }
     }
}