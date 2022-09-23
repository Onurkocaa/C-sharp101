using System;

namespace phonebook
{
    public class UpdateNumber:NumberClass
    {
        public void Update()
        {
            Menu:
           Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını soyadınız giriniz:");
           string name = Console.ReadLine();
           int others = 0;
           foreach (var item in contact)
           {
            if(item.Value.Contains(name))
            {
                Console.WriteLine("Yeni numarayı giriniz:");
                string numbers= Console.ReadLine();
                string newname = item.Value;
                contact.Remove(item.Key);
                contact.Add(numbers, newname);
                break;
            }
            else
            {
                others++;
            }
             if(others == contact.Count)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için           : (2)");
                string choice = Console.ReadLine();
                if(choice == "1")
                {
                    Console.WriteLine("Güncelleme sonlandırıldı.");
                }
                else if(choice == "2")
                {
                   goto Menu;
                }
                foreach(var gunc in contact)
                Console.WriteLine(gunc);
            }
           }

        }
    }
}