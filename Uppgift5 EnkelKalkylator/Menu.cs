
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
            var calculator = new Calculator();

            //Meny med while loop
            while (true)
            {
                Console.WriteLine(" ---- Miniräknare ---- \n" +
                "\n\tVälj en av följande operationer för vad du önskar att göra:" +
                "\n\t1. Addera" +
                "\n\t2. Subtrahera" +
                "\n\t3. Dividera" +
                "\n\t4. Multiplicera" +
                "\n\tEsc. Avsluta programmet");

                //Switch med readkey för enklare användning + Felhantering med default
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Du har valt Addition");
                        break;

                    case ConsoleKey.D2:
                        //Anropar metod för input och substation
                        calculator.UserInput(out double sub1, out double sub2);
                        calculator.Substract(sub1, sub2);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine("Du har valt Division");
                        break;

                    case ConsoleKey.D4:
                        //Anropar metod för input och multiplikation
                        calculator.UserInput(out double mul1, out double mul2);
                        calculator.Multiplicate(mul1, mul2);
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