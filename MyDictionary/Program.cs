using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("İrem");
            isimler.Add("Azra");
            isimler.Add("Can");
            isimler.Add("Görkem");
            isimler.Add("Gizem");
            Console.WriteLine("Eleman sayısı: "+isimler.Count);
            isimler.All();
        }
    }
}
