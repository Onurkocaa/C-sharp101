using System;

namespace phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
           
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1" :
                NewNumber newnumber = new NewNumber();
                newnumber.add();
                newnumber.ListContact();
                break;

                case "2" :
                DeleteNumber deletenumber = new DeleteNumber();
                deletenumber.Delete();
                break;

                case "3" :
                UpdateNumber updatenum = new UpdateNumber();
                updatenum.Update();
                break;

                case"4" :
                NumberClass numbercon = new NumberClass();
                numbercon.ListContact();
                break;
                
                case "5":
                SearchNumber searcnum = new SearchNumber();
                searcnum.Search();
                break;

            }
            Console.ReadLine();

        }
    }
}
