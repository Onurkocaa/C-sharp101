using System;

namespace ToDoApp
{
    class DeleteCard
    {
        public void Delete()
        {
            Delete:
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string namecard = Console.ReadLine();

            Card DeleteCard = Database.Cards.FirstOrDefault(x=> x.Title == namecard);
            if(DeleteCard != null)
            {
              Database.Cards.Remove(DeleteCard);
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.(1)Silme işlemini sonlandırmek için.(2)Yeniden denemek için");
                string choice = Console.ReadLine();
                if(choice == "1")
                {
                    Console.WriteLine("Silme işlemi sonlandırıldı.");
                }
                else if(choice =="2")
                {
                  goto Delete;
                }
            }
        }
    }
}