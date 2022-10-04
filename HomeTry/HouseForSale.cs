using System;

namespace HomeTry
{
    class HouseForSale
    {
        public static List<Home> salehouse = new List<Home>();
        public void SaleHouse()
        {
          salehouse = new List<Home>()
          {
             new Home{Odasayısı =2,Evadresi="Güvenevler mahallesi 151231 sokak asdas sitesi 4.kat 8 numara ", metrekaresi=100,ısınmasistemi="Klima",Evilcesi="Yenişehir",Fiyatı=1000000},
             new Home{Odasayısı =3,Evadresi="Menteş mahallesi 123231 sokak asdas sitesi 6.kat 12 numara ", metrekaresi=160,ısınmasistemi="Doğalgaz",Evilcesi="Yenişehir",Fiyatı=1200000},
              new Home{Odasayısı =3,Evadresi="ADASD mahallesi 1231 sokak asdas sitesi 2.kat 4 numara ", metrekaresi=200,ısınmasistemi="Doğalgaz",Evilcesi="Mezitli",Fiyatı=2500000},
          };
        }
    }
}