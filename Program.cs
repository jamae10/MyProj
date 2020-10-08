using System;

namespace MidTermProj//
{//
    class MainMenu
    {
        public int choice;
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

        //get user input in Main Menu
        public int getMainMenu()
        {
            Boolean cc = true;

            while (cc)
            {
                Console.WriteLine("Enter Number of Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice <= 0 || choice > 7)
                {
                    Console.WriteLine("Invalid Choice of Number. Please Try Again.\n");
                }

                else { break; }
            }
            return choice;
        }

        //Main Method
        static void Main(string[] args)
        {
            Boolean loop = true;
            do
            {
                MainMenu menu = new MainMenu();
                menu.displayMainMenu();
                menu.getMainMenu();
                break;
            } while (loop);
        }

        
    }
}//
