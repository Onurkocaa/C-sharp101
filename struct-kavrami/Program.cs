using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
           Diktortgen diktortgen = new Diktortgen();
           //diktortgen.Kısakenar = 3;
           //diktortgen.Uzunkenar = 4;

           Console.WriteLine("Class Alan Hesabı     :{0}",diktortgen.AlanHesapla());

           Diktortgen_Struct diktortgen_struct;
           diktortgen_struct.Kısakenar = 3;
           diktortgen_struct.Uzunkenar = 4;

           Console.WriteLine("Class Alan Hesabı     :{0}",diktortgen_struct.AlanHesapla());
        }
    }
    class Diktortgen
    {
        public int Kısakenar;
        public int Uzunkenar;
        //public Diktortgen(){
            //Kısakenar = 3;
            //Uzunkenar = 4;
        //}
        public long AlanHesapla()
        {
            return this.Kısakenar * this.Uzunkenar;
        }
    }
    struct Diktortgen_Struct
    {
        public int Kısakenar;
        public int Uzunkenar;
        public Diktortgen_Struct(int kısakenar, int uzunkenar)
        {
            Kısakenar = kısakenar;
            Uzunkenar = uzunkenar;
        }
        public long AlanHesapla()
        {
           return this.Kısakenar * this.Uzunkenar; 
        }
    }
}
