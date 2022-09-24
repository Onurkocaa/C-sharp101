using System;

namespace phonebook
{
    public class DeleteNumber:NumberClass
    {
        public void Delete()
        {
          Menu:
          Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
          string nameSurname = Console.ReadLine();
          int other =0;
          foreach (var item in contact)
          {
            if(item.Value.Contains(nameSurname))
            {
            contact.Remove(item.Key);
            Console.WriteLine("Başarıyla silinmiştir."+item.Value);
            break;
            }
            else
            {
                other++;      
            }
            if(other == 1)
            {
               Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
               Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
               Console.WriteLine("*Yeniden denemek için      : (2)");
               string choice = Console.ReadLine();
               if(choice =="1")
               {
                Console.WriteLine("İşleminiz sonlandırıldı.");
               }
               else if(choice =="2")
               {
                goto Menu;
               }
               foreach(var sil in contact)
               Console.WriteLine(sil);
               
            }

          }
           
        }
    }
}
