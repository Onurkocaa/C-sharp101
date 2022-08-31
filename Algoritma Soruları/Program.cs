using System;

namespace AlgoritmaSoruları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.soru
          //Kullanıcıdan n adet pozitif tam sayı girmesini iste.
          //n adet pozitif sayı girmesini iste çift olanları yazdır.
          
          Console.WriteLine("Pozitif tam sayı giriniz: ");
          int n = int.Parse(Console.ReadLine());

          int[] sayiDizisi = new int[n];
          for(int i=0; i<n; i++)
          {
            Console.WriteLine("Lütfen {0}. sayıyı giriniz:",i+1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
          }
          foreach (int item in sayiDizisi)
          {
            if(item%2 == 0)
            Console.WriteLine(item);
          }

           //2.soru
          //Kullanıcıdan n,m adet pozitif tam sayı girmesini iste.
          //n adet pozitif sayı girmesini iste m eşit yada tam bölünenleri yazdır.
          
          Console.WriteLine("Pozitif tam sayı giriniz: ");
          int n = int.Parse(Console.ReadLine());
          Console.WriteLine("Pozitif tam sayı giriniz: ");
          int m = int.Parse(Console.ReadLine());

          int[] sayiDizisi = new int[n];
          for(int i=0; i<n; i++)
          {
            Console.WriteLine("Lütfen {0}. sayıyı giriniz:",i+1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
          }
          foreach (int item in sayiDizisi)
          {
            if(item%m == 0)
            Console.WriteLine(item);
          }

         //3.Soru
         // Pozitif bir sayı girmesini iste "n"
         // n adet kelime girmesini iste kelimeleri sondan başa doğru yazdır.
        Console.WriteLine("Lütfen kelime miktarını giriniz:");
        int n=int.Parse(Console.ReadLine());
        string[] kelimeler=new string[n];
                       
         for(int i=0;i<n;i++)
            {
              Console.WriteLine("Lütfen {0}.kelimeyi giriniz:",i+1);
              kelimeler[i]+=Console.ReadLine();
                        
            }
             for(int i=n-1;i>=0;i--)
             {
               Console.WriteLine(kelimeler[i]);
             }

            //4.Soru
            //bir cümle yazmasını iste.
            // cümledeki toplam kelime ve harf sayısı console yazdır.
            
            Console.WriteLine("Lütfen bir cümle yazınız:");
            string cümle = Console.ReadLine();

            string[] kelime = cümle.Split(" ");                        //cümleyi bölmek için split kullanılır.
            Console.WriteLine("Kelime Sayısı:"+kelime.Length);
            Console.WriteLine(cümle.Length-(kelime.Length-1));      //cümle yazılırken boşlukları harf olarak saymaması için -1.
        }
    }
}