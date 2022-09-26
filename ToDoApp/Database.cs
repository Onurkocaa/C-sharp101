using System;

namespace ToDoApp
{
    class Database
    {
       public static List<Card> Cards= new List<Card>();
       public static List<Person> PersonList = new List<Person>();
        static Database()
        {
        Cards = new List<Card>()
         {
            new Card{Title="Ödevler", Content="Web API ödevini yapacak. ",Person="Onur", Size="L",Line="TODO" },
            new Card{Title="Proje", Content="Proje dosyalarını tamamlayacak. ", Person="Tevfik", Size="M",Line="IN PROGRESS" },
            new Card{Title="Toplantı", Content="08.05.2022 00.00 da toplantı yapılacak ", Person="Şebnem", Size="XL",Line="DONE" },
            new Card{Title="Egitim", Content="Eğitim videoları izlenecek.", Person="Ahmet", Size="XS",Line="TODO" },
         };

         PersonList = new List<Person>()
         {
            new Person{Id=1,Name="Onur"},
            new Person{Id=2,Name="Tevfik"},
            new Person{Id=3,Name="Şebnem"},
            new Person{Id=4,Name="Ahmet"},
         };
        }

    } 
}