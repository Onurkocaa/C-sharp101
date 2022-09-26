using System;

namespace ToDoApp
{
    class MoveCard
    {
        public void Move()
        {
            Move:
            Console.WriteLine(" Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.Lütfen kart başlığını yazınız:");
            string cardmove = Console.ReadLine();
            
            Card MoveCard = Database.Cards.FirstOrDefault(x=> x.Title == cardmove);

            if(MoveCard !=null)
            {
                Console.WriteLine("Bulunan kart bilgiler");
            Console.WriteLine("*******************************************");

            Console.WriteLine("Başlık      :  {0}", MoveCard.Title);
            Console.WriteLine("İçerik      :  {0}", MoveCard.Content);
            Console.WriteLine("Atanan Kişi :  {0}", MoveCard.Person);
            Console.WriteLine("Büyüklük    :  {0}", MoveCard.Size);
            Console.WriteLine("Line        :  {0}\n", MoveCard.Line);

            Console.WriteLine("Lütfen taşımak istediğiniz durum'u seçiniz");
            Console.WriteLine("(0) TODO");
            Console.WriteLine("(1) IN PROGRESS");
            Console.WriteLine("(2) DONE");

            int line = int.Parse(Console.ReadLine());

            if (line == 0) { MoveCard.Line = "TODO"; }
            else if (line == 1) { MoveCard.Line = "IN PROGRESS"; }
            else if (line == 2) { MoveCard.Line = "DONE"; }
            else { MoveCard.Line = "Hatalı bir seçim yaptınız!"; }

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
                  goto Move;
                }
            }

        }
    }
}