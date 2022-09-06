using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
          //her iki grubun kendi içerisinde ortalamalarını alan ve 
          //bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
          //ArrayList sayılar = new ArrayList();
          double[] sayı = new double[20];
          for(int i=0;i<20;i++)
          {
            Console.WriteLine("Lütfen {0}.sayıyı giriniz:",i+1);
            double n = int.Parse(Console.ReadLine());
            sayı[i]=n;
          }
          Array.Sort(sayı);
          double[] min = new double[3];
          min[0] = sayı[0]; 
          min[1] = sayı[1];
          min[2] = sayı[2];
          double[] max = new double[3];
          max[0] = sayı[17];
          max[1] = sayı[18];
          max[2] = sayı[19];
          
          foreach(var item in min)
          Console.WriteLine(item);
          foreach(var item in max)
          Console.WriteLine(item);
          Console.WriteLine("En küçük 3 sayının ortalaması: "+Ortalama(min));
          Console.WriteLine("En büyük 3 sayının ortalaması: "+Ortalama(max));
          Console.WriteLine("En büyük ve en küçük sayının ortalaması: "+(Ortalama(min)+Ortalama(max))/3);
        }
        static int Ortalama(double[] i)
        {
            int total = 0;
            foreach (int number in i)
                total += number;
            return total / i.Length;
        }

    }
}


