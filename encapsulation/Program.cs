using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim="Onur";
            ogrenci.Soyisim="Koca";
            ogrenci.OgrenciNo=777;
            ogrenci.Sınıf=3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SınıfAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Tevfik","Zaim",132,1);
            ogrenci1.SınıfDusur();
            ogrenci1.OgrenciBilgileriniGetir();

        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sınıf;

        public string Isim 
        {
            get { return isim; } 
            set { isim = value; } 
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sınıf 
        { 
         get => sınıf; 
         set
         {
            if(value<=1)
            {
                Console.WriteLine("Sınıf En Az 1 Olmalıdır.");
                sınıf = 1;
            }
            else
            sınıf = value;
         } 
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo = 0, int sınıf = 0)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sınıf = sınıf;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*********** Öğrenci Bilgileri *********");
            Console.WriteLine("Öğrenci Adı        :{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı     :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci No         :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıf      :{0}",this.Sınıf);


        }
        public void SınıfAtlat()
        {
            this.Sınıf = this.Sınıf +1;
        }
        public void SınıfDusur()
        {
            this.Sınıf = this.Sınıf -1;
        }
    }
}
