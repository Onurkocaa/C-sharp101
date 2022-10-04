using System;

namespace HomeTry
{
     class SearchRentHouse
    {
        public void SearchRent()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine(" Oda sayısına göre arama yapmak için: (1)");
            Console.WriteLine(" Fiyatına göre arama yapmak için: (2)");
            string searc = Console.ReadLine();
            if(searc =="1")
            {
                Console.WriteLine("Lütfen Odasayısını giriniz:");
                int cs=int.Parse(Console.ReadLine());
                Home hosse = HouseForRent.renthouse.FirstOrDefault(x=>x.Odasayısı==cs);
                if(hosse !=null)
                {
                    Console.WriteLine("Odasayısı : "+hosse.Odasayısı);
                    Console.WriteLine("Ev Adresi  :"+hosse.Evadresi);
                    Console.WriteLine("Metre Karesi:"+hosse.metrekaresi);
                    Console.WriteLine("Isınma Sistemi:"+hosse.ısınmasistemi);
                    Console.WriteLine("İlçesi:"+hosse.Evilcesi);
                    Console.WriteLine("Metre Karesi:"+hosse.metrekaresi);
                }
                else 
                {
                    Console.WriteLine("Aradığınız kriterlerde ev bulunamadı.");

                }
            }
        }
    }
}