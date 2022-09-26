using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
          start:
          Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
          Console.WriteLine("*******************************************");
          Console.WriteLine("(1) Board Listelemek");
          Console.WriteLine("(2) Board'a Kart Eklemek");
          Console.WriteLine("(3) Board'dan Kart Silmek");
          Console.WriteLine("(4) Kart Taşımak");

          int selection = int.Parse(Console.ReadLine());

         switch (selection)
         {
          case 1:
         ListBoard selection1 = new ListBoard();
         selection1.List();
         break;
          case 2:
          AddCard selection2 = new AddCard();
          selection2.Add();
          break;
          case 3:
         DeleteCard selection3 = new DeleteCard();
         selection3.Delete();
         break;
          case 4:
         MoveCard selection4 = new MoveCard();
         selection4.Move();
          break;
        default:
          break;  
         }
        }
    }
}

     
    
