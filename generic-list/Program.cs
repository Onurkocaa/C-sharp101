﻿using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {

        static void Main(string[] args)
        {

           //List<T> class
           //System.Collections.Generic
           //T=> object türündedir.

           List<int> sayiListesi = new List<int>();

           sayiListesi.Add(23);
           sayiListesi.Add(10);
           sayiListesi.Add(4);
           sayiListesi.Add(5);
           sayiListesi.Add(92);
           sayiListesi.Add(34);

           List<string> renkListesi = new List<string>();
           renkListesi.Add("Kırmızı");
           renkListesi.Add("Mavi");
           renkListesi.Add("Turuncu");
           renkListesi.Add("Sarı");
           renkListesi.Add("Yeşil");

           //Count
           Console.WriteLine(renkListesi.Count);
           Console.WriteLine(sayiListesi.Count);

           //Foreach ve List.ForEach ile elemanlara erişim
           foreach (var renk in renkListesi)
           Console.WriteLine(renk);
           foreach (var sayi in sayiListesi)
           Console.WriteLine(sayi);

           sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
           renkListesi.ForEach(renk=> Console.WriteLine(renk));

           //Listede eleman çıkarma
           sayiListesi.Remove(4);
           renkListesi.Remove("Yeşil"); 

           sayiListesi.RemoveAt(0);
           renkListesi.RemoveAt(1);

           sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
           renkListesi.ForEach(renk=> Console.WriteLine(renk));

           //Liste içersinde arama
           if(sayiListesi.Contains(10))
           Console.WriteLine("10 Liste içerisinde bulundu!");

           //Eleman ile index e erişim
           Console.WriteLine(renkListesi.BinarySearch("Turuncu"));

           //Diziyi List e çevirme
           string[] hayvanlar = {"Kedi","Köpek","Kuş"};
           List<string> hayvanlarListesi = new List<string>(hayvanlar);

           //Listeyi nasıl temizleriz
           hayvanlarListesi.Clear();

           //Liste içersinde nesne tutmak
           List<Kullanıcılar> kullancıListesi = new List<Kullanıcılar>();
           Kullanıcılar kullanıcı1 = new Kullanıcılar();
           kullanıcı1.Isim = "Onur";
           kullanıcı1.Soyisim ="Koca";
           kullanıcı1.Yas = 26;
           
           Kullanıcılar kullanıcı2 = new Kullanıcılar();
           kullanıcı2.Isim = "Tevfik";
           kullanıcı2.Soyisim = "Zaim";
           kullanıcı2.Yas = 26;

           kullancıListesi.Add(kullanıcı1);
           kullancıListesi.Add(kullanıcı2);

           List<Kullanıcılar> yeniListe = new List<Kullanıcılar> ();

           yeniListe.Add(new Kullanıcılar(){
            Isim="Deniz",
            Soyisim="Arda",
            Yas=24


           });

           foreach (var kullanıcı in kullancıListesi)
           {
               Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
               Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
               Console.WriteLine("Kullanıcı Yas:" + kullanıcı.Yas);
           }

           yeniListe.Clear();

        }
    }
    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value;}
        public string Soyisim { get => soyisim; set => soyisim = value;}
        public int Yas { get => yas; set => yas = value; }

    }
}

