using System;

namespace polymorphism_sealed
{
    class Program  //Polymorphism:Çok biçimlilik
    {
    public class Base  
    {  
        public virtual void Show()  
        {  
            Console.WriteLine("Show From Base Class.");  
        }  
    }  
    public class Derived : Base  
    {  
        //the keyword "override" change the base class method.  
        public override void Show()  
        {  
            base.Show();
            Console.WriteLine("Show From Derived Class.");  
        }  
    }  
    public sealed class Base2
    {
        protected void sealedMethod(){
            Console.WriteLine(" Cannot derive from sealed class ");
        }
    }
    //public class SealedClass:Base2
    //{
        //sealed edildiği için katılım yapılamıyor.
    //}
    static void Main(string[] args)  
    {  
        Base deneme  = new Derived();  
        deneme .Show();//Output--> Show From Derived Class.  
        Console.ReadLine();  
    } 
  }
}
