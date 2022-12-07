using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        
        public void Strings_1()
        {
            
            string Name = "Peter";
            int i = 23;
            double num = 12.5;

            Console.SetCursorPosition(40, 8);
            Console.WriteLine(Name);
            Console.SetCursorPosition(40, 9);
            Console.WriteLine(i);
            Console.SetCursorPosition(40, 10);
            Console.WriteLine(num);
        }

        public void Strings_2()
        {
            string Name = "Stefanos";
            int i = 23;
            double num = 12.5;

            Console.SetCursorPosition(40, 8);
            Console.WriteLine(Name);
            Console.SetCursorPosition(40, 9);
            Console.WriteLine(i);
            Console.SetCursorPosition(40, 10);
            Console.WriteLine(num);
        }


        public void Strings_3()
        {
            string z = "I dag har vi den 24. December";

            Console.SetCursorPosition(40, 8);
            Console.WriteLine(z);
        }

        public void Strings_4()
        {
            double amount = 200.50;
            string c = "Jeg har ";
            string v = "kr. i banken";

            Console.SetCursorPosition(40, 8);
            Console.WriteLine(c + amount + v );
        }

        public void Aritmetiske_Udtryk_1()
        {
            int i = 2 + 1 * 2;
            int x = (2+1) * 2;
            int y = 5 / 2;
            decimal v = 8 % 3;
            decimal b = 1 - 5;

            Console.SetCursorPosition(40, 8);
            Console.WriteLine(i);
            Console.SetCursorPosition(40, 9);
            Console.WriteLine(x);
            Console.SetCursorPosition(40, 10);
            Console.WriteLine(y);
            Console.SetCursorPosition(40, 11);
            Console.WriteLine(v);
            Console.SetCursorPosition(39, 12);
            Console.WriteLine(b);
        }

        public void Variabler_i_Udtryk_1()
        {
            int i = 30;
            int a = 2;
            int r = 54;

            int result = i + a * r;

            Console.SetCursorPosition(40, 8);
            Console.WriteLine(result);
        }

        public void Variabler_i_Udtryk_2()
        {
            int Peter = 23;
            int Stefanos = 22;
            int Elias = 50;

            int result = Peter + Stefanos + Elias;

            Console.SetCursorPosition(40, 8);
            Console.WriteLine("Peter " + Peter);
            Console.SetCursorPosition(40, 9);
            Console.WriteLine("Stefanos " + Stefanos);
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("Elias " + Elias);
            Console.SetCursorPosition(40, 11);
            Console.WriteLine(result);
            Console.SetCursorPosition(40, 12);
            Console.WriteLine(Elias + 5);
        }

        public void Boolske_variable_1()
        {
            int var1 = 10;
            int var2 = 11;
            bool i = var1 < var2;

            Console.SetCursorPosition(40, 8);
            Console.WriteLine(i);
        }

        public void If_else_statements_1()
        {
            int tal1 = 36;
            int tal2 = 64;
            int result = tal1 + tal2;

            if (result > 100)
            {
                Console.SetCursorPosition(40, 8);
                Console.WriteLine("Summen er større end 100!");
            }
            else if (result < 100)
            {
                Console.SetCursorPosition(40, 8);
                Console.WriteLine("Summen er mindre end 100");
            }
            else
            {
                Console.SetCursorPosition(40, 8);
                Console.WriteLine("Summen er 100");
            }
        
        }

        public void If_else_statements_2()
        {
            Console.SetCursorPosition(40, 7);
            Console.WriteLine("Alder: ");
            Console.SetCursorPosition(47, 7);
            int alder = Convert.ToInt32(Console.ReadLine());

            if (alder > 57)
            {
                Console.SetCursorPosition(40, 7);
                Console.WriteLine("Du er for gammel");
            }
            else if (alder <= 57)
            {
                Console.SetCursorPosition(40, 7);
                Console.WriteLine("Du er ikke for gammel");
            }
        }


        public void If_else_statements_3()
        {
            Console.SetCursorPosition(40, 7);
            Console.WriteLine("Alder: ");
            Console.SetCursorPosition(47, 7);
            int alder = Convert.ToInt32(Console.ReadLine());

            if (alder > 60)
            {
                Console.SetCursorPosition(40, 7);
                Console.WriteLine("Du er for gammel");
            }
            else if (alder > 50 && alder < 60)
            {
                Console.SetCursorPosition(40, 7);
                Console.WriteLine("Du er hverken for gammel eller for ung");
            }
            else if (alder < 50)
            {
                Console.SetCursorPosition(40, 7);
                Console.WriteLine("Du er for ung");
            }
        }

        public void If_else_statements_4()
        {
            string navn = "peter";
            string brugernavn = "petela";
            int password = 1234;

            Console.SetCursorPosition(40, 7);
            Console.WriteLine("navn: ");
            Console.SetCursorPosition(46, 7);
            navn = Console.ReadLine();

            Console.SetCursorPosition(40, 8);
            Console.WriteLine("brugernavn: ");
            Console.SetCursorPosition(52, 8);
            brugernavn = Console.ReadLine();

            Console.SetCursorPosition(40, 9);
            Console.WriteLine("password: ");
            Console.SetCursorPosition(50, 9);
            password = Convert.ToInt32(Console.ReadLine());

            if (navn == "peter" && brugernavn == "petela" && password == 1234)
            {
                Console.SetCursorPosition(40, 11);
                Console.WriteLine("Velkommen " + navn);
            }
            else
            {
                Console.SetCursorPosition(40, 11);
                Console.WriteLine("brugernavn eller password er forkert");
            }
        }

        public void If_else_statements_5()
        {
          
            string brugernavn = "petela";
            int password = 1234;

           

            Console.SetCursorPosition(40, 7);
            Console.WriteLine("brugernavn: ");
            Console.SetCursorPosition(52, 7);
            brugernavn = Console.ReadLine();


            if (brugernavn == "petela")
            {
                Console.SetCursorPosition(40, 8);
                Console.WriteLine("password: ");
                Console.SetCursorPosition(50, 8);
                password = Convert.ToInt32(Console.ReadLine());


                if (password == 1234)
                {
                    Console.SetCursorPosition(40, 12);
                    Console.WriteLine("Velkommen " + brugernavn);
                }
                else if (password != 1234)
                {
                    Console.SetCursorPosition(40, 13);
                    Console.WriteLine("Password er forkert");
                }

            }
            else if (brugernavn != "petela")
            {
                Console.SetCursorPosition(40, 14);
                Console.WriteLine("brugernavnet er forkert");
            }

        
        }

        public void If_else_statements_6()
        {

            Console.SetCursorPosition(40, 7);
            Console.WriteLine("hvor mange km der køres hver dag til og fra arbejde: ");
            Console.SetCursorPosition(93, 7);
            int km = Convert.ToInt32(Console.ReadLine());

            double formel = (km - 24) * 1.93;
            double formel2 = 96 * 1.93 + (km - 120) * 0.97;

            if (km <= 24)
            {
                Console.SetCursorPosition(40, 8);
                Console.WriteLine("Du får ikke noget fradrag");
            }
            else if (km >= 25 && km <= 120)
            {
                Console.SetCursorPosition(40, 8);
                Console.WriteLine(formel);
            }
            else if (km > 121)
            {
                Console.SetCursorPosition(40, 8);
                Console.WriteLine(formel);
            }

        }

        public void If_else_statements_7()
        {
            
            Console.Title = "Festen";
            
            string colors = "";

            Console.SetCursorPosition(40, 8);
            Console.WriteLine("Age: ");
            Console.SetCursorPosition(45, 8);
            int Age = Convert.ToInt32(Console.ReadLine());


            Console.SetCursorPosition(40, 9);
            Console.WriteLine("Choose a color (red, green, blue, yellow): ");
            Console.SetCursorPosition(83, 9);
            colors = Console.ReadLine();


            if (colors == "red")
            {
                
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
            }
            else if (colors == "green")
            {
                
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
            }
            else if (colors == "blue")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
            }
            else if (colors == "yellow")
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
            }

            if (Age > 18)
            {
                Console.SetCursorPosition(45, 9);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Velkommen til cocktailbaren");
                Thread.Sleep(10000);
                Console.ResetColor();
                Console.Clear();
               
            }
            else
            {
                Console.SetCursorPosition(45, 9);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Velkommen til  sodavandsbaren");
                Thread.Sleep(10000);
                Console.ResetColor();
                Console.Clear();
            }
           

        }


        public void Switch_Case_1()
        {
            Console.SetCursorPosition(40, 8);
            Console.WriteLine("Choose a number from 1-6: ");
            Console.SetCursorPosition(66, 8);
            int num = Convert.ToInt32(Console.ReadLine());



            switch (num)
            {
                case 1:
                    Console.SetCursorPosition(40, 10);
                    Console.WriteLine("Du har tastet " + num);
                    Console.ReadKey();
                    break;

                case 2:
                    Console.SetCursorPosition(40, 10);
                    Console.WriteLine("Du har tastet " + num);
                    Console.ReadKey();
                    break;

                case 3:
                    Console.SetCursorPosition(40, 10);
                    Console.WriteLine("Du har tastet " + num);
                    Console.ReadKey();
                    break;

                case 4:
                    Console.SetCursorPosition(40, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("TILLYKKE DU HAR VUNDET");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.SetCursorPosition(40, 10);
                    Console.WriteLine("Du har tastet " + num);
                    Console.ReadKey();
                    break;

                case 6:
                    Console.SetCursorPosition(40, 10);
                    Console.WriteLine("Du har tastet " + num);
                    Console.ReadKey();
                    break;

                default:
                    Console.SetCursorPosition(40, 10);
                    Console.WriteLine("Du har tastet forkert. Tallet skal være mellem 1 og 6");
                    Thread.Sleep(10000);
                    Console.ResetColor();
                    Console.Clear();
                    break;
            }
        }

        public void Switch_Case_2()
        {
            int[] price = {34, 23, 54, 12, 65, 10};
            string[] drinks = {"Isbjørn", "Champagnebrus", "Tequila Sunrise", "Mojito", "Brandbil", "Filur"};

            Console.SetCursorPosition(40, 8);
            Console.WriteLine("Choose a Drink: ");
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("1. Isbjørn ");
            Console.SetCursorPosition(40, 11);
            Console.WriteLine("2. Champagnebrus");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("3. Tequila Sunrise");
            Console.SetCursorPosition(40, 13);
            Console.WriteLine("4. Mojito");
            Console.SetCursorPosition(40, 14);
            Console.WriteLine("5. Brandbil");
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("6. Filur");
            Console.SetCursorPosition(56, 8);
            int drink = Convert.ToInt32(Console.ReadLine());

            switch (drink)
            {
                case 1:
                    Console.SetCursorPosition(40, 18);
                    Console.WriteLine("You have Chosen " + drinks[0] + " and it costs " + price[0] + " USD");
                    break;

                case 2:
                    Console.SetCursorPosition(40, 18);
                    Console.WriteLine("You have Chosen " + drinks[1] + " and it costs " + price[1] + " USD");
                    break;

                case 3:
                    Console.SetCursorPosition(40, 18);
                    Console.WriteLine("You have Chosen " + drinks[2] + " and it costs " + price[2] + " USD");
                    break;

                case 4:
                    Console.SetCursorPosition(40, 18);
                    Console.WriteLine("You have Chosen " + drinks[3] + " and it costs " + price[3] + " USD");
                    break;

                case 5:
                    Console.SetCursorPosition(40, 18);
                    Console.WriteLine("You have Chosen " + drinks[4] + " and it costs " + price[4] + " USD");
                    break;

                case 6:
                    Console.SetCursorPosition(40, 18);
                    Console.WriteLine("You have Chosen " + drinks[5] + " and it costs " + price[5] + " USD");
                    break;

                default:
                    Console.SetCursorPosition(40, 18);
                    Console.WriteLine("Invalid Option!");
                    break;
            }


        }





    }
}
