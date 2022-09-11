using System;

namespace static_sinif_üyeler
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Çalişan Sayısı :{0}",Calisan.CalisanSayisi);

           Calisan calisan = new Calisan("Onur","Koca","IK");
           Console.WriteLine("Çalişan Sayı :{0}",Calisan.CalisanSayisi);
           Calisan calisan1 = new Calisan("Ali","Koca","IK");
           Calisan calisan2 = new Calisan("Veli","Koca","IK");
           Console.WriteLine("Çalişan Sayı :{0}",Calisan.CalisanSayisi);

           Console.WriteLine("Toplama işlemi sonucu:{0}",İslemler.Topla(100,200));
           Console.WriteLine("Çıkarma işlemi sonucu:{0}",İslemler.Çıkar(400,50));
           

        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calisan(){
            calisanSayisi = 0;

        }
        public Calisan(string ısim, string soyisim, string departman)
        {
            this.Isim = Isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }
    }
    static class İslemler
    {
        public static long Topla(int sayı1, int sayı2)
        {
            return  sayı1+ sayı2;
        }
        public static long Çıkar(int sayı1, int sayı2)
        {
            return sayı1- sayı2;
        }
    }
}