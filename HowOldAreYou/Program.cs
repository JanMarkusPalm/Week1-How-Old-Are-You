
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there, whats your name?");
            //readline() to read the user input from the console
            string UserName = Console.ReadLine();
            //Console.WriteLine("SUP SUP, " + UserName + "!");

            //string interpolation     V        V
            Console.WriteLine($"Hello, {UserName}");
            Console.WriteLine("How old are you? Write Digits only:");


            int Age = Int32.Parse(Console.ReadLine());
            int YearOfBirth = 2021 - Age;
            Console.WriteLine("you were born in " + YearOfBirth);



            //Kaks voimalust kuidas kasutada $ ja +
            //Console.WriteLine("you were born in " + YearOfBirth);
            //Console.WriteLine($"you were born in {YearOfBirth}"); 


            //El33t h4x0r; ctrl alt num important
            Console.Read();
            

        }
    }
}