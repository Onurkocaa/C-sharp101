using System;
using System.Collections.Generic;

namespace dictionary
{
class Program
{
    static void Main(string[] args)
    {
        //System.collection.generic
        Dictionary<int,string> kullancılar = new Dictionary<int, string>();

        kullancılar.Add(10,"Ayşe Yılmaz");
        kullancılar.Add(12,"Ahmet Yılmaz");
        kullancılar.Add(18,"Onur Koca");
        kullancılar.Add(20,"Tevfik Zaim");

        //Dizinin elemanlarına erişim
        Console.WriteLine("***** Elemanlara Erişim *****");
        Console.WriteLine(kullancılar[12]);
        foreach (var item in kullancılar)
        Console.WriteLine(item);

        //Count
        Console.WriteLine("***** Count *****");
        Console.WriteLine(kullancılar.Count());

        //Contains
        Console.WriteLine("*****    Contains *****");
        Console.WriteLine(kullancılar.ContainsKey(12));
        Console.WriteLine(kullancılar.ContainsValue("Onur Koca"));

        //Remove
        Console.WriteLine("*****   Remove *****");
        kullancılar.Remove(12);
        foreach(var item in kullancılar)
        Console.WriteLine(item);

        //Keys
        Console.WriteLine("*****  Keys *****");
        foreach(var item in kullancılar.Keys)
        Console.WriteLine(item);
        //Values
        Console.WriteLine("***** Values *****");
        foreach(var item in kullancılar.Values)
        Console.WriteLine(item);
        
    }
}
}
