using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suiiii
{
    public class Opgaver
    {

        public void Variabler_1()
        {

            int tal1 = 5;
            int tal2 = 3;

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(tal1);
            Console.SetCursorPosition(40, 8);
            Console.WriteLine(tal2);
        }

        public void Variabler_2()
        {
            int tal1 = 5;
            int tal2 = 3;

            Console.SetCursorPosition(40, 7);
            Console.WriteLine("Tal1 er" + " " + tal1);
            Console.SetCursorPosition(40, 8);
            Console.WriteLine("Tal2 er" + " " + tal2);
        }

        public void Variabler_3()
        {
            string Navn = "Søren";
            int Alder = 16;
            double Penge = 1234.34;

            Console.SetCursorPosition(20, 7);
            Console.WriteLine("Jeg hedder "+ Navn + ", er " + Alder + " år gammel og har tjent " + Penge + " kr. på at lappe cykler");
        }

        public void Variabler_4()
        {
            double Kage = 23.56;
            double Øl = 34.67;
            double Pølse = 65.34;

            Console.SetCursorPosition(40, 7);
            Console.WriteLine("Kage " + Kage + " \n                                        Øl " + Øl + " \n                                        Pølse" + Pølse);
            Console.SetCursorPosition(40, 11);
            Console.WriteLine("I alt");
            Console.SetCursorPosition(46, 11);
            Console.WriteLine(Kage + Øl + Pølse);
        }
        
        public void Variabler_5()
        {
            Console.SetCursorPosition(40, 7);
            Console.WriteLine("Navn: ");
            Console.SetCursorPosition(46, 7);
            string Navn = Console.ReadLine();

            Console.SetCursorPosition(40, 8);
            Console.WriteLine("Alder: ");
            Console.SetCursorPosition(47, 8);
            string Alder = Console.ReadLine();

            Console.SetCursorPosition(40, 10);
            Console.WriteLine("Jeg hedder " + Navn + " og er " + Alder + " år gammel");
        }


        public void Variabler_6()
        {
            double PI = Math.PI;
         

            Console.SetCursorPosition(40, 7);
            Console.WriteLine("Radius: ");
            Console.SetCursorPosition(48, 7);
            double Radius = Convert.ToDouble(Console.ReadLine());
            double Areal = PI * (Radius * Radius);

            Console.SetCursorPosition(40, 8);
            Console.WriteLine("Areal: " + Areal);


        }



    }
}
