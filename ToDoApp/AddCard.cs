using System;

namespace ToDoApp
{
    class AddCard
    {
        public void Add()
        {
           Card newcard = new Card();

          Console.WriteLine("Card Ekleme Bölümü");
          Console.WriteLine("*******************************************");
          Console.Write("Başlık Giriniz: ");
          newcard.Title=Console.ReadLine();
          Console.WriteLine("İçerik Giriniz:");
          newcard.Content=Console.ReadLine();
          Console.WriteLine("Lütfen Büyüklük Seçiniz=/n(1)XS,(2)S,(3)M,(4)L,(5)XL:");
          int size = int.Parse(Console.ReadLine());
          
          if(size !=null)
          {
            string SizeValue = Enum.GetName (typeof(EnumSize),size);
            newcard.Size=SizeValue;
          }
          else
          {
            Console.WriteLine("Geçersiz bir karakter girdiniz tekrark deneyin.");
          }
          deneme:
          Console.WriteLine("Kişi seçiniz:");
          string personName=Console.ReadLine();
          if(Database.PersonList.Find(a=>a.Name==personName).Name==personName)
          {
             Database.Cards.Add(newcard);
             Console.WriteLine("Kartınız oluşturulmuştur.");
          }
          else
          {
             Console.WriteLine("Hatalı giriş yaptınız. Tekrar deneyiniz.");
             goto deneme;
             
          }
        }
    }
}