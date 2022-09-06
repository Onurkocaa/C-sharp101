﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_soru_1
{
     class Program
    {
       static void Main()
       {
                  // Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
          //Negatif ve numeric olmayan girişleri engelleyin.Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
          //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.          
                  ArrayList sayilarListesi = new ArrayList();
                
                try
                {
                    for(int i = 0; i < 20; i++)
                {
                    Console.Write("Lütfen {0}. pozitif sayıyı giriniz: ",i ++);
                    int sayi = int.Parse(Console.ReadLine());

                    if(sayi < 0)
                    {
                        Console.Write("Hata oluştu.Lütfen pozitif bir sayı giriniz.");
                        break;
                    }
                    else
                       sayilarListesi.Add(sayi);  
                }
            }
            catch (FormatException exc)
            {
                Console.WriteLine("Hata oluştu.Lütfen rakam giriniz." + exc.Message);
            }

            ArrayList asalSayilarListesi = new ArrayList();
            ArrayList asalOlmayanSayilarListesi = new ArrayList();

            foreach (int sayi in sayilarListesi)
            {
                if (AsalMi(sayi))
                   asalSayilarListesi.Add(sayi);
                else
                   asalOlmayanSayilarListesi.Add(sayi);
            }

            asalSayilarListesi.Sort();
            asalSayilarListesi.Reverse();
            Console.WriteLine();
            Console.WriteLine("Asal sayıların büyükten küçüğe sıralı listesi: ");
            ListeYazdir(asalSayilarListesi);
            Console.WriteLine("Asal sayılar listesinin eleman sayısı: {0} ve ortalaması: {1}", asalSayilarListesi.Count , OrtalamaYazdir(asalSayilarListesi));

            asalOlmayanSayilarListesi.Sort();
            asalOlmayanSayilarListesi.Reverse();
            Console.WriteLine();
            Console.WriteLine("Asal olmayan sayıların büyükten küçüğe sıralı listesi: ");
            ListeYazdir(asalOlmayanSayilarListesi);
            Console.WriteLine("Asal olmayan sayılar listesinin eleman sayısı: {0} ve ortalaması: {1}", asalOlmayanSayilarListesi.Count , OrtalamaYazdir(asalOlmayanSayilarListesi));
        }
        static bool AsalMi(int sayi)
        {
            if(sayi == 1 || sayi == 0)
            return false;

            for(int i = 2; i < sayi; i++)
            {
                if(sayi % i == 0)
                return false;
            }
            return true;
        }
        static void ListeYazdir(ArrayList liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.Write(liste[i] + " ");
            }
            Console.WriteLine();
        }
        static double OrtalamaYazdir(ArrayList liste)
        {
            int toplam = 0;
            for (int i = 0; i < liste.Count; i++)
            {
                toplam += Convert.ToInt32(liste[i]);
            }
            double ortalama = (double)toplam / liste.Count;
            return ortalama;
        }
    }
}