using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suiiii
{
    public class Projects
    {
        string[] opgave = {"Opgave 1", "Opgave 2", "Opgave 3", "Opgave 4", "Opgave 5", "Opgave 6", "Opgave 7", "Opgave 8", "Opgave 9", "Type 10 to EXIT"};
        public void Variabler()
        {

            main_menu main_Menu = new main_menu();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Variabler --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);
            Console.SetCursorPosition(40, 8);
            Console.WriteLine(opgave[1]);
            Console.SetCursorPosition(40, 9);
            Console.WriteLine(opgave[2]);
            Console.SetCursorPosition(40, 10);
            Console.WriteLine(opgave[3]);
            Console.SetCursorPosition(40, 11);
            Console.WriteLine(opgave[4]);
            Console.SetCursorPosition(40, 12);
            Console.WriteLine(opgave[5]);
            Console.SetCursorPosition(40, 13);
            Console.WriteLine(opgave[6]);
            Console.SetCursorPosition(40, 14);
            Console.WriteLine(opgave[7]);
            Console.SetCursorPosition(40, 15);
            Console.WriteLine(opgave[8]);
            Console.SetCursorPosition(40, 17);
            Console.WriteLine(opgave[9]);

            Console.SetCursorPosition(40, 25);
            Console.WriteLine("Chooose a Project or EXIT: ");

            Console.SetCursorPosition(67, 25);
            int chooseOpgave = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (chooseOpgave)
            {









                case 10:
                    main_Menu.mainMenu();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Option! Please try again.");
                    
                    break;

            }


        }
    }
}
