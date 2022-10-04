using System;

namespace HomeTry
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hoşgeldiniz!");
           Console.WriteLine("*********");
           Console.WriteLine("Bakmak istediğiniz ev (1)Kiralık  ise 1'i,(2)Satılık ise 2'i giriniz: ");
           string choice = Console.ReadLine();
           switch (choice)
           {
            case "1":
            SearchRentHouse kıra = new SearchRentHouse();
            kıra.SearchRent();
            break;
           }
        }
    }
}