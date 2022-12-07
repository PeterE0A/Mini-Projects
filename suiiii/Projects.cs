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

        main_menu main_Menu = new main_menu();
        Opgaver opgaver = new Opgaver();
        public void Variabler()
        {

            

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
            Console.SetCursorPosition(40, 23);
            Console.WriteLine(opgave[9]);

            Console.SetCursorPosition(40, 25);
            Console.WriteLine("Chooose a Project or EXIT: ");

            Console.SetCursorPosition(67, 25);
            int chooseOpgave = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (chooseOpgave)
            {
                case 1:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Variabler --------------------");
                   
                    opgaver.Variabler_1();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 2:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Variabler --------------------");

                    opgaver.Variabler_2();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 3:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Variabler --------------------");

                    opgaver.Variabler_3();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 4:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Variabler --------------------");

                    opgaver.Variabler_4();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 5:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Variabler --------------------");

                    opgaver.Variabler_5();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 6:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Variabler --------------------");

                    opgaver.Variabler_6();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;





                case 10:
                    main_Menu.mainMenu();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Option! Please try again.");
                    
                    break;

            }


        }


        public void Strings()
        {

            

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Strings --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);
            Console.SetCursorPosition(40, 8);
            Console.WriteLine(opgave[1]);
            Console.SetCursorPosition(40, 9);
            Console.WriteLine(opgave[2]);
            Console.SetCursorPosition(40, 10);
            Console.WriteLine(opgave[3]);
            
            Console.SetCursorPosition(40, 23);
            Console.WriteLine(opgave[9]);

            Console.SetCursorPosition(40, 25);
            Console.WriteLine("Chooose a Project or EXIT: ");

            Console.SetCursorPosition(67, 25);
            int chooseOpgave = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (chooseOpgave)
            {
                case 1:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Strings --------------------");

                    opgaver.Strings_1();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 2:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Strings --------------------");

                    opgaver.Strings_2();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 3:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Strings --------------------");

                    opgaver.Strings_3();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 4:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Strings --------------------");

                    opgaver.Strings_4();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;









                case 10:
                    main_Menu.mainMenu();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Option! Please try again.");

                    break;

            }


        }



        public void Aritmetiske_Udtryk()
        {

            

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Aritmetiske Udtryk --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);
           

            Console.SetCursorPosition(40, 23);
            Console.WriteLine(opgave[9]);

            Console.SetCursorPosition(40, 25);
            Console.WriteLine("Chooose a Project or EXIT: ");

            Console.SetCursorPosition(67, 25);
            int chooseOpgave = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (chooseOpgave)
            {



                case 1:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Aritmetiske Udtryk --------------------");

                    opgaver.Aritmetiske_Udtryk_1();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;





                case 10:
                    main_Menu.mainMenu();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Option! Please try again.");

                    break;

            }


        }


        public void Variabler_i_Udtryk()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Variabler i Udtryk --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);
            Console.SetCursorPosition(40, 8);
            Console.WriteLine(opgave[1]);


            Console.SetCursorPosition(40, 23);
            Console.WriteLine(opgave[9]);

            Console.SetCursorPosition(40, 25);
            Console.WriteLine("Chooose a Project or EXIT: ");

            Console.SetCursorPosition(67, 25);
            int chooseOpgave = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (chooseOpgave)
            {


                case 1:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Variabler i Udtryk --------------------");

                    opgaver.Variabler_i_Udtryk_1();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 2:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Variabler i Udtryk --------------------");

                    opgaver.Variabler_i_Udtryk_2();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;






                case 10:
                    main_Menu.mainMenu();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Option! Please try again.");

                    break;

            }


        }

        public void Boolske_variable()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Boolske Variable --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);
       

            Console.SetCursorPosition(40, 23);
            Console.WriteLine(opgave[9]);

            Console.SetCursorPosition(40, 25);
            Console.WriteLine("Chooose a Project or EXIT: ");

            Console.SetCursorPosition(67, 25);
            int chooseOpgave = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (chooseOpgave)
            {

                case 1:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Boolske Variable --------------------");

                    opgaver.Boolske_variable_1();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;







                case 10:
                    main_Menu.mainMenu();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Option! Please try again.");

                    break;

            }


        }


        public void If_else_statements()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- If-else Statements --------------------");

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


            Console.SetCursorPosition(40, 23);
            Console.WriteLine(opgave[9]);

            Console.SetCursorPosition(40, 25);
            Console.WriteLine("Chooose a Project or EXIT: ");

            Console.SetCursorPosition(67, 25);
            int chooseOpgave = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (chooseOpgave)
            {


                case 1:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- If-else Statements --------------------");

                    opgaver.If_else_statements_1();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 2:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- If-else Statements --------------------");

                    opgaver.If_else_statements_2();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 3:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- If-else Statements --------------------");

                    opgaver.If_else_statements_3();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 4:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- If-else Statements --------------------");

                    opgaver.If_else_statements_4();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;


                case 5:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- If-else Statements --------------------");

                    opgaver.If_else_statements_5();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;


                case 6:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- If-else Statements --------------------");

                    opgaver.If_else_statements_6();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 7:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- If-else Statements --------------------");

                    opgaver.If_else_statements_7();
                    //Console.ReadKey();
                    main_Menu.mainMenu();
                    break;





                case 10:
                    main_Menu.mainMenu();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Option! Please try again.");

                    break;

            }


        }

        public void Switch_Case()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Switch Case --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);
            Console.SetCursorPosition(40, 8);
            Console.WriteLine(opgave[1]);
    

            Console.SetCursorPosition(40, 23);
            Console.WriteLine(opgave[9]);

            Console.SetCursorPosition(40, 25);
            Console.WriteLine("Chooose a Project or EXIT: ");

            Console.SetCursorPosition(67, 25);
            int chooseOpgave = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (chooseOpgave)
            {

                case 1:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Switch Case --------------------");

                    opgaver.Switch_Case_1();
                    //Console.ReadKey();
                    main_Menu.mainMenu();
                    break;

                case 2:
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("-------------------- Switch Case --------------------");

                    opgaver.Switch_Case_2();
                    Console.ReadKey();
                    main_Menu.mainMenu();
                    break;





                case 10:
                    main_Menu.mainMenu();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Option! Please try again.");

                    break;

            }


        }

        public void Loops()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Loops --------------------");

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


            Console.SetCursorPosition(40, 23);
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

        public void Udvidet_Kontrolstrukturer()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Udvidet Kontrolstrukturer --------------------");

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
          

            Console.SetCursorPosition(40, 23);
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


        public void Metoder_og_instanser()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Metoder og instancer --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);
            Console.SetCursorPosition(40, 8);
            Console.WriteLine(opgave[1]);


            Console.SetCursorPosition(40, 23);
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


        public void Returtyper_og_parametre()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Returtyper og parametre --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);
            Console.SetCursorPosition(40, 8);
            Console.WriteLine(opgave[1]);
            Console.SetCursorPosition(40, 9);
            Console.WriteLine(opgave[2]);
            Console.SetCursorPosition(40, 10);
            Console.WriteLine(opgave[3]);


            Console.SetCursorPosition(40, 23);
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

        public void Instancevariabler()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Instancevariabler --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);



            Console.SetCursorPosition(40, 23);
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






        public void Nedarvning()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Nedarvning --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);
            


            Console.SetCursorPosition(40, 23);
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



        public void Konstruktors()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Konstruktors --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);



            Console.SetCursorPosition(40, 23);
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

        public void Arrays()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Arrays --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);



            Console.SetCursorPosition(40, 23);
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



        public void Gennemløb_af_arrays()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Gennemløb af arays --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);



            Console.SetCursorPosition(40, 23);
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



        public void Public_Private_og_Protected()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            Console.SetCursorPosition(35, 4);
            Console.WriteLine("-------------------- Public, Private og Protected --------------------");

            Console.SetCursorPosition(40, 7);
            Console.WriteLine(opgave[0]);



            Console.SetCursorPosition(40, 23);
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
