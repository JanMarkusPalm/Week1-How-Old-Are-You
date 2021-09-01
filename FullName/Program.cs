using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what's your name?");
            String Username = Console.ReadLine();
            Console.WriteLine("Hello, " + Username + " Whats your surname?");
            String Username1 = Console.ReadLine();
            Console.WriteLine($"Hello, {Username} {Username1}");


            //program kusib kasutaja kaest kasutaja eesnime ja perekonnanime
            //program tervitab kasutajat kasutades neid andmeid

        }
    }
}
