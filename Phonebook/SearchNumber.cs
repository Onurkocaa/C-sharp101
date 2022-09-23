using System;

namespace phonebook
{
    public class SearchNumber:NumberClass
    {
        public void Search()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string choice = Console.ReadLine();
            if(choice =="1")
            {
                Console.WriteLine("Lütfen arama yapacağınız isim veya soyisim giriniz:");
                string namSurnam= Console.ReadLine();
                foreach(var item in contact)
                {
                    if(item.Value.Contains(namSurnam))
                    {
                        Console.WriteLine("Arama Sonuçlarınız:");
                        Console.WriteLine("**********************************************");
                        Console.WriteLine("İsim-Soyisim:"+item.Value);
                        Console.WriteLine("Telefon Numarası:"+item.Key);
                        Console.WriteLine("----");
                        break;
                    }
                    else{
                        continue;
                    }
                }
            }
             else if(choice == "2")
            {
                Console.WriteLine("Lütfen arama yapacağınız telefon numarası giriniz:");
                string num= Console.ReadLine();
                foreach(var item in contact)
                {
                    if(item.Key.Contains(num))
                    {
                        Console.WriteLine("Arama Sonuçlarınız:");
                        Console.WriteLine("**********************************************");
                        Console.WriteLine("İsim-Soyisim:"+item.Value);
                        Console.WriteLine("Telefon Numarası:"+item.Key);
                        Console.WriteLine("-----");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}