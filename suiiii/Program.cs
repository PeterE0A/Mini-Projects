using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suiiii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            main_menu main_Menu = new main_menu();
            main_Menu.mainMenu();
            Console.ReadKey();
        }
    }
}
