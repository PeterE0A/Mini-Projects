using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace suiiii
{
    public class main_menu
    {
       
        string[] project = { "Variabler", "Strings", "Aritmetiske udtryk", "Variabler i udtryk", "Boolske variable", "If-else statements", "Switch Case", "Loops", "Udvidet kontrolstrukturer", "Metoder og instanser", "Returtyper og parametre", "Instancevariabler", "Nedarvning", "Konstruktors", "Arrays", "Gennemløb af arrays", "Public, Private og Protected", "Exit" };
        
        public void mainMenu()
        {

            Projects projects = new Projects();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;  
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Welcome --------------------");
            Console.SetCursorPosition(40, 7);
            Console.WriteLine("1." + "  " + project[0]);
            Console.SetCursorPosition(40, 8);
            Console.WriteLine("2." + "  " + project[1]);
            Console.SetCursorPosition(40, 9);
            Console.WriteLine("3." + "  " + project[2]);
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("4." + "  " + project[3]);
            Console.SetCursorPosition(40, 11);
            Console.WriteLine("5." + "  " + project[4]);
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("6." + "  " + project[5]);
            Console.SetCursorPosition(40, 13);
            Console.WriteLine("7." + "  " + project[6]);
            Console.SetCursorPosition(40, 14);
            Console.WriteLine("8." + "  " + project[7]);
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("9." + "  " + project[8]);
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("10." + " " + project[9]);
            Console.SetCursorPosition(40, 17);
            Console.WriteLine("11." + " " + project[10]);
            Console.SetCursorPosition(40, 18);
            Console.WriteLine("12." + " " + project[11]);
            Console.SetCursorPosition(40, 19);
            Console.WriteLine("13." + " " + project[12]);
            Console.SetCursorPosition(40, 20);
            Console.WriteLine("14." + " " + project[13]);
            Console.SetCursorPosition(40, 21);
            Console.WriteLine("15." + " " + project[14]);
            Console.SetCursorPosition(40, 22);
            Console.WriteLine("16." + " " + project[15]);
            Console.SetCursorPosition(40, 23);
            Console.WriteLine("17." + " " + project[16]);

            Console.SetCursorPosition(40, 25);
            Console.WriteLine("Chooose a Project: ");

            Console.SetCursorPosition(59, 25);
            int chooseproject = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (chooseproject)
            {
                case 1:
                    projects.Variabler();
                    break;

                default:
                    
                    Console.WriteLine("Invalid Option! Please try again.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

            }



        }
    }
}
