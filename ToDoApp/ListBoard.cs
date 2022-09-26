using System;

namespace ToDoApp
{
    class ListBoard
    {
        public static Board Boards = new Board();
        public void BoardLine()
        {
         var toDo = Database.Cards.Where(x => x.Line == "TODO").ToList();
         var ınProgress = Database.Cards.Where(x => x.Line == "IN PROGRESS").ToList();
         var done = Database.Cards.Where(x => x.Line == "DONE").ToList();

         Boards = new Board();
         Boards.Todo = toDo;
         Boards.Inprogress = ınProgress;
         Boards.Done = done;
        }
            public void List()
        {
        BoardLine();
        ShowCard(" TODO Line", Boards.Todo);
        ShowCard(" IN PROGRESS Line", Boards.Inprogress);
        ShowCard(" DONE Line", Boards.Done);

        }
        void ShowCard(string boardLine,List<Card> ListAll)
        {
           Console.WriteLine(boardLine);
           Console.WriteLine("*******************************************");
        foreach (var item in ListAll)
        {
            Console.WriteLine("Başlık      :  {0}", item.Title);
            Console.WriteLine("İçerik      :  {0}", item.Content);
            Console.WriteLine("Atanan Kişi :  {0}", item.Person);
            Console.WriteLine("Büyüklük    :  {0}\n",item.Size);
        }
        } 
        
    }
}