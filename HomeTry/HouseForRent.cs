using System;

namespace HomeTry
{
    class HouseForRent
    {
        public static List<Home> renthouse = new List<Home>();
        public void RentHouse()
        {
          renthouse = new List<Home>()
          {
            new Home{Odasayısı =3,Evadresi="Güvenevler mahallesi 151231 sokak asdas sitesi 3.kat 4 numara ", metrekaresi=110,ısınmasistemi="Doğalgaz",Evilcesi="Yenişehir",Fiyatı=5000},
            new Home{Odasayısı =2,Evadresi="Fuat moral mahallesi 123123 sokak asfas sitesi 5.kat 10 numara",metrekaresi=70,ısınmasistemi="Klima",Evilcesi="Akdeniz",Fiyatı=7000},
            new Home{Odasayısı =4,Evadresi="asfdasd mahallesi 124223 sokak asadfas sitesi 1.kat 2 numara",metrekaresi=200,ısınmasistemi="Doğalgaz",Evilcesi="Mezitli",Fiyatı=9000},
          };


        }
    }
}