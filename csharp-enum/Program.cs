using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
           //Console.WriteLine(Gunler.Pazar);
           //Console.WriteLine((int)Gunler.Cumartesi);

           Console.WriteLine("Havanın Derecesini Giriniz:");
           int sıcaklık = int.Parse(Console.ReadLine());
           
           if(sıcaklık<=(int)HavaDurumu.Normal)
           Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
           else if(sıcaklık>=(int)HavaDurumu.Sıcak)
           Console.WriteLine("Dışarıya çıkmak için çık sıcak bir gün.");
           else if (sıcaklık>=(int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.CokSıcak)
           Console.WriteLine("Hadi dışarıya çıkalım");
           
        }
    }

    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar,

    }
    enum HavaDurumu
    {
      Soguk=5,
      Normal=20,
      Sıcak=25,
      CokSıcak=30,
    }
}