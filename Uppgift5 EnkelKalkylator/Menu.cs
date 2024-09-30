
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
                Console.Clear(); //Rensar konsolen för att få den mer läsbar
                Console.WriteLine(" ---- Miniräknare ---- \n" +
                "\n\tVälj en av följande operationer för vad du önskar att göra:" +
                "\n\t1. Addera" +
                "\n\t2. Subtrahera" +
                "\n\t3. Dividera" +
                "\n\t4. Multiplicera" +
                "\n\t5. Upphöjt till" +
                "\n\t6. Roten ur" +
                "\n\tEsc. Avsluta programmet");

                //Switch med readkey för enklare användning + Felhantering med default
                switch (Console.ReadKey(true).Key)
                {
                    
                    //Anropar metod för input och addition
                    case ConsoleKey.D1:
                        calculator.UserInputTwoValues(out double add1, out double add2);
                        calculator.Addition(add1, add2);
                        break;
                    
                    //Anropar metod för input och substation
                    case ConsoleKey.D2:
                        
                        calculator.UserInputTwoValues(out double sub1, out double sub2);
                        calculator.Substract(sub1, sub2);
                        break;

                    //Anropar metod för input och substation
                    case ConsoleKey.D3:
                        calculator.UserInputTwoValues(out double div1, out double div2);
                        calculator.Divide(div1, div2);
                        break;

                    //Anropar metod för input och multiplikation
                    case ConsoleKey.D4:
                        calculator.UserInputTwoValues(out double mul1, out double mul2);
                        calculator.Multiplicate(mul1, mul2);
                        break;

                    //Anropar metod för input och upphöjt till
                    case ConsoleKey.D5:
                        calculator.UserInputTwoValues(out double po1, out double po2);
                        calculator.PowerOf(po1, po2);
                        break;
                    //Anropar metod för input och upphöjt till
                    case ConsoleKey.D6:
                        calculator.UserInputOneValue(out double squ1);
                        calculator.SquareRoot(squ1);
                        break;

                    //Avslutar whileloopen och programmet
                    case ConsoleKey.Escape:
                        Console.WriteLine("Programmet avslutas...");
                        Environment.Exit(0);
                        break;

                    //Felhantering av val som inte finns i menyn
                    default:
                        Console.WriteLine("Ogiltligt val, vänligen ange ett av valen i menyn");
                        break;  
                }
                //Efter visad resultat får användaren trycka på valfri tangent för att återgå till menyn
                Console.WriteLine("\nTryck på valfri tangent för att återgå till menyn...");
                Console.ReadKey();
            }


        }
    }
}