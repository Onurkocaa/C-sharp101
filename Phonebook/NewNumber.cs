using System;

namespace phonebook
{
    public class NewNumber:NumberClass
    {
        public void add()
        {
            Console.WriteLine("Lütfen isim giriniz      :");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz   :");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz:");
            string number = Console.ReadLine();
            contact.Add(name+""+surname,number);
            Console.WriteLine("İşleminiz başarıyla tamamlandı.",number,name+""+surname);
        }

    }
}
