using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
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
            Console.WriteLine("Jeg hedder " + Navn + ", er " + Alder + " år gammel og har tjent " + Penge + " kr. på at lappe cykler");
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
            Console.WriteLine(c + amount + v);
        }

        public void Aritmetiske_Udtryk_1()
        {
            int i = 2 + 1 * 2;
            int x = (2 + 1) * 2;
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
            int[] price = { 34, 23, 54, 12, 65, 10 };
            string[] drinks = { "Isbjørn", "Champagnebrus", "Tequila Sunrise", "Mojito", "Brandbil", "Filur" };

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

        public void Loops_1()
        {
            int num = 0;

            while (num < 10)
            {

                num++;
                Console.WriteLine(num);

            }


            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Loops_2()
        {
            int num = 0;

            while (num < 100)
            {

                num++;
                Console.WriteLine(num);

            }


            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Loops_3()
        {
            for (int i = 5; i < 105; i += 5)
            {
                Console.WriteLine(i);
            }
        }


        public void Loops_4()
        {
            int num = 21;

            while (num > 1)
            {
                num--;
                Console.WriteLine(num);

            }


            for (int i = 20; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public void Loops_5()
        {
            int num = 7;

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", i, num, (num * i));
            }
        }

        public void Loops_6()
        {
            Console.SetCursorPosition(40, 8);
            Console.WriteLine("Type a Number: ");
            Console.SetCursorPosition(55, 8);
            int num = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < 11; i++)
            {

                Console.WriteLine("{0} * {1} = {2}", i, num, (num * i));
            }
        }


        public void Loops_7()
        {


            for (int y = 4; y <= 8; y++)
            {
                for (int x = 20; x <= 30; x++)
                {
                    if (y == 4 || y == 8 || x == 20 || x == 30)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }



        }

        public void Loops_8()
        {


            string name = "peter";
            int nameStart = (30 - 20 - name.Length) / 2 + 20;

            for (int y = 4; y <= 8; y++)
            {
                for (int x = 20; x <= 30; x++)
                {
                    if (y == 4 || y == 8 || x == 20 || x == 30)
                    {
                        Console.Write("*");
                    }
                    else if (y == 6 && x >= nameStart && x < nameStart + name.Length)
                    {
                        Console.Write(name[x - nameStart]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }

        public void Loops_9()
        {

            // Get the size of the frame from the user
            Console.WriteLine("Enter the size of the frame: ");
            int size = int.Parse(Console.ReadLine());

            // Get the text that should be written in the middle of the frame
            Console.WriteLine("Enter the text to be written in the middle of the frame: ");
            string text = Console.ReadLine();

            // Calculate the length of the text
            int textLength = text.Length;

            // Calculate the starting and ending positions of the text in the frame
            int startPos = (size - textLength) / 2;
            int endPos = startPos + textLength;

            // Use a for loop to create the top and bottom of the frame
            for (int i = 0; i < size; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // Use a for loop to create the sides of the frame
            for (int i = 0; i < size - 2; i++)
            {
                // Print the left side of the frame
                Console.Write("*");

                // Print the text in the middle of the frame
                for (int j = 0; j < size - 2; j++)
                {
                    if (j >= startPos && j < endPos)
                    {
                        Console.Write(text[j - startPos]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                // Print the right side of the frame
                Console.WriteLine("*");
            }

            // Use a for loop to create the bottom of the frame
            for (int i = 0; i < size; i++)
            {
                Console.Write("*");
            }

        }

        public void Udvidet_kontrolstrukturer_1()
        {
            // Set the starting value for the counter variable
            int counter = 3;

            // Create the for-loop
            for (int i = 1; i <= 7; i++)
            {
                // Print the current number
                Console.WriteLine(counter);

                // Check if the current number is 21
                if (counter == 21)
                {
                    // If the current number is 21, stop the loop
                    break;
                }

                // Increment the counter variable by 3 after each iteration
                counter += 3;
            }

            // Print a message after the loop has stopped
            Console.WriteLine("The Loop has now stopped");



        }

        public void Udvidet_kontrolstrukturer_2()
        {
            // Set the starting value for the counter variable
            int counter = 4;

            // Create the while loop
            while (counter <= 20)
            {
                // Check if the current number is 16
                if (counter == 16)
                {
                    // If the current number is 16, skip this iteration
                    counter += 4;
                    continue;
                }

                // Print the current number
                Console.WriteLine(counter);

                // Increment the counter variable by 4 after each iteration
                counter += 4;
            }

            // Print a message after the loop has stopped
            Console.WriteLine("The Loop has now stopped");

        }

        public void Udvidet_kontrolstrukturer_3()
        {
            // Calculate transport deductions

            // Distance in km
            Console.Write("Enter the distance traveled in km: ");
            double distance = double.Parse(Console.ReadLine());

            // First 24 km no deduction
            double deduction = 0;
            if (distance > 24)
            {
                // 25-100 km 154 øre per km
                if (distance <= 100)
                {
                    deduction = (distance - 24) * 0.154;
                }
                // Over 100 km 77 øre per km
                else
                {
                    deduction = (100 - 24) * 0.154 + (distance - 100) * 0.77;
                }
            }

            // Print the result
            Console.WriteLine("Transport deductions: " + deduction);
        }


        public void Udvidet_kontrolstrukturer_4()
        {
            Console.Write("Enter your income: ");
            double income = double.Parse(Console.ReadLine());

            double tax = 0;
            if (income >= 390000)
            {
                tax += (income - 390000) * 0.15;
                income = 390000;
            }
            if (income >= 280000)
            {
                tax += (income - 280000) * 0.06;
                income = 280000;
            }
            if (income >= 42000)
            {
                tax += (income - 42000) * 0.3;
            }

            if (tax > 0)
            {
                Console.WriteLine("You must pay a tax of DKK " + tax);
            }
            else
            {
                Console.WriteLine("You do not have to pay any tax");
            }
        }


        public void Udvidet_kontrolstrukturer_5()
        {
            // Ask the user how much money is in the account
            Console.WriteLine("How much money is in the account?");
            var amount = double.Parse(Console.ReadLine());

            // Determine the interest rate based on the amount in the account
            double interestRate;
            if (amount < 25000)
            {
                interestRate = 0.25;
            }
            else if (amount <= 150000)
            {
                interestRate = 1.25;
            }
            else
            {
                interestRate = 1.25 + 0.5;
            }

            // Calculate the interest using the formula:
            // interest = amount * interest rate / 100
            var interest = amount * interestRate / 100;

            // Print the interest with 2 decimal places
            Console.WriteLine($"The interest is: {interest:F2}");
        }


        public void Metoder_og_instanser_1()
        {
            Book SherlockHolmes = new Book(150,"Jeg er en bog");
            SherlockHolmes.PrintInfo();
            
        }

       
        public void Metoder_og_instanser_2()
        {
            Book SherlockHolmes = new Book(150, "Jeg er en bog");
           
         

            if (SherlockHolmes.HarRåd(150, 200))
            {
                Console.WriteLine("I can afford it");
            }
            else
            {
                Console.WriteLine("I unfortunately can't afford it");
            }
        }


        public void Returtyper_og_parametre_1()
        {
            Bil bil = new Bil();
            bil.MotorStartet();
            bil.MotorSlukket();
        }

        public void Returtyper_og_parametre_2()
        {
            Bil bil = new Bil();
            bil.fillgas(2.5);
        }

        public double benzin()
        {
            return 2.5;
        }

       

        public void Returtyper_og_parametre_3()
        {
            Bil bil = new Bil();
            bil.FillGas(benzin(), false);
        }


        public void Returtyper_og_parametre_4()
        {
            Bil bil = new Bil();
            bil.RemainingGas(1.1);
        }


        public void Instancevariabler_1()
        {
            Book book = new Book(150, "Jeg er en bog");

            // Set the price and title of the book
            book.SetPrice(240);
            book.SetTitle("Moby Dick");

            // Determine if we have enough money to buy the book
            if (book.CanAffordBook(500))
            {
                Console.WriteLine(book.GetTitle() + " - costs DKK " + book.GetPrice());
            }
            else
            {
                Console.WriteLine("Not enough money to buy " + book.GetTitle());
            }
        }





        public void Nedarvning_1()
        {
            var chair = new Chair
            {
                Material = "Wood",
                Color = "Red",
                NumberOfLegs = 4,
                Upholstery = "Leather"
            };

            var computer = new Computer
            {
                Material = "Plastic",
                Color = "Black",
                NumberOfLegs = 0,
                OperatingSystem = "Windows 10"
            };

            Console.WriteLine("Chair: ");
            Console.WriteLine("Material: " + chair.Material);
            Console.WriteLine("Color: " + chair.Color);
            Console.WriteLine("Number of legs: " + chair.NumberOfLegs);
            Console.WriteLine("Upholstery: " + chair.Upholstery);

            Console.WriteLine("Computer: ");
            Console.WriteLine("Material: " + computer.Material);
            Console.WriteLine("Color: " + computer.Color);
            Console.WriteLine("Number of legs: " + computer.NumberOfLegs);
            Console.WriteLine("Operating system: " + computer.OperatingSystem);

        }


        public void konstruktors_1()
        {
            Book book = new Book(150, "Harry Potter");

            book.Reading();
        }


        public void Arrays_1()
        {
            int[] i = { -2, -1, 0, 10 };

            Console.WriteLine(i[3] + " " +  i[1]);
            Console.WriteLine(i[0] + i[1] + i[2] + i[3]);
        }

        public void Gennemløb_af_arrays_1()
        {
            int[] i = {1,2,3,4,5,6,7,8,9,10};
            int sum = 0;

            for (int x = 0; x < i.Length; x++)
            {
                sum += i[x];
            }

            Console.WriteLine("The sum of the values is: " + sum);

        } 


        public void Public_Private_og_Protected()
        {
            Console.WriteLine("");
            Console.WriteLine("Private: In C#, the private keyword is an access modifier that is used to specify the access level of a class member (such as a field, method, or property). A member marked as private is only accessible within the class in which it is declared. It is not accessible from outside the class, or from derived classes (classes that inherit from the class where the private member is declared). ");
            Console.WriteLine("");
            Console.WriteLine("Protected: In C#, the protected keyword is an access modifier that is used to specify the access level of a class member (such as a field, method, or property). A member marked as protected is only accessible within the class in which it is declared, and from derived classes (classes that inherit from the class where the protected member is declared). It is not accessible from outside the class.");
            Console.WriteLine("");
            Console.WriteLine("Public: In C#, the public keyword is an access modifier that is used to specify the access level of a class member (such as a field, method, or property). A member marked as public is accessible from anywhere within the program, including from outside the class in which it is declared.");


        }




    }

}





