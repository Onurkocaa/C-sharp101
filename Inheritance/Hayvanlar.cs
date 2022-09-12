using System;

namespace Inheritance
{
  public  class Hayvanlar:Canlilar
    {
       protected void Adaptasyon(){
        Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
       }
    }
    public class Sürüngeler:Hayvanlar{
        public Sürüngeler(){
            base.Adaptasyon();
        }
        public void SürünerekHareket(){
            Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }
    public class Kuslar:Hayvanlar{
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
             base.Solunum();

        }
        public void Ucmak(){
            Console.WriteLine("Kuşlar uçar.");
        }
    }
}