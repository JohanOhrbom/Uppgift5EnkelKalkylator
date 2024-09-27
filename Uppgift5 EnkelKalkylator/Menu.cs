
using System;

namespace EnkelKalkylator
{
    public class Menu
    {

        public Menu()
        {
        }

        internal void MainMenu()
        {

            while (true)
            {
                Console.WriteLine(" ---- Miniräknare ---- \n" +
                "\n\tVälj en av följande operationer för vad du önskar att göra:" +
                "\n\t1. Addera" +
                "\n\t2. Subtrahera" +
                "\n\t3. Dividera" +
                "\n\t4. Multiplicera" +
                "\n\tEsc. Avsluta programmet");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Du har valt Addition");
                       



                        break;
                    case ConsoleKey.D2:
                        //Mata in tal ()
                        calculator.UserInput(out double tal1, out double tal2);

                        calculator.Substract(tal1, tal2);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("Du har valt Division");
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("Du har valt Multiplikation");
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Du har valt att avsluta programmet");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Fel format vänligen ange ett val ur menyn");
                        break;


                
                }

            }


        }
    }
}