using System;

namespace phonebook
{
   public class NumberClass
    {
       public Dictionary<string, string> contact = new Dictionary<string, string>();

       public NumberClass()
       {
        contact.Add("123456", "Onur Koca" );
        contact.Add("123457", "Ali Veli" );
        contact.Add("123458", "Tevfik Zaim" );
        contact.Add("123459", "Şebnem Zaim" );
        contact.Add("123451", "Bade Bayrak" );
       }
       public void ListContact()
       {
          foreach(var item in contact)
          {
            Console.WriteLine(item);
          }
       }
    }
}
