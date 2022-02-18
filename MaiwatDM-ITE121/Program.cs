using System;


namespace Daniela
{
    class Program
    {
        static void Main(string [] args)
        {
            int age;
            string name, lName;
            int curYear = DateTime.Now.Year;

            Console.Write("Enter your first name: ");
            name = Console.ReadLine();
            
            Console.Write("Enter your last name: ");
            lName = Console.ReadLine(); 

            Console.Write("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine($"{name} {lName} was born in the year {curYear - age} ");
            Console.WriteLine("");
            Console.WriteLine("-------------------");

            Console.WriteLine("Created by: Daniela Demaiwat - BSIT1");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}