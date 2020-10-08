using System;

namespace MidTermProj//
{//
    class MainMenu
    {
        //Main Menu Table
        public void displayMainMenu()
        {
            Console.WriteLine("================================");
            Console.WriteLine($"{" ", -12}{"Main Menu", -10}");
            Console.WriteLine("================================");
            Console.WriteLine("[1] Arithmetic ");
            Console.WriteLine("[2] String Problems");
            Console.WriteLine("[3] Unit Converter");
            Console.WriteLine("[4] Array Sorting");
            Console.WriteLine("[5] Math Class");
            Console.WriteLine("[6] Patterns");
            Console.WriteLine("[7] Exit");
            Console.WriteLine("================================");

        }

        //Main Method
        static void Main(string[] args)
        {
            Boolean loop = true;
            do
            {
                MainMenu menu = new MainMenu();
                menu.displayMainMenu();
                break;
            } while (loop);
        }

        
    }
}//
