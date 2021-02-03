using System;

namespace ProjectNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            string countString = cat.Amount(5).ToString();
            Console.WriteLine(countString);
        }
    }
}
