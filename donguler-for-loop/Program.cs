using System;

namespace donguler_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
          // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
          Console.WriteLine("Lütfen bir sayı giriniz: ");
          int sayac = int.Parse(Console.ReadLine());
          for (int i = 1; i <= sayac; i++)
          {
           if(i%2 == 1)
           Console.WriteLine(i);
          }
          // 1 ile 1000 arasındaki tek ve çift sayılarının kendi içlerinde toplamlarını ekrana yazdır.
         int tektoplam =  0;
         int çifttoplam = 0;
          for (int i = 1; i <= 1000; i++)

          {
          if(i%2 == 1)
          tektoplam += i; //tektoplam = tektoplam + i
          else
          çifttoplam += i;   
          }
        Console.WriteLine("Tek Toplam: " +tektoplam);
        Console.WriteLine("Çift Toplam:" + çifttoplam);  

        // break, continue

        for (int i = 1; i < 10; i++)
        {
            if(i==4)
            break;
            Console.WriteLine(i);
        }
         for (int i = 1; i < 10; i++)
        {
            if(i==4)
            continue;
            Console.WriteLine(i);
        }
      }
    }
}
