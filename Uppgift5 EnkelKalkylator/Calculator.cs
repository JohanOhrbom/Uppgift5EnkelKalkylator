namespace EnkelKalkylator
{

    internal class Calculator

    {//class calc
        public double Resultat { get; set; }

        //Metod för att ta in data för ett tal
        public void UserInputOneValue(out double tal1)
        {
            tal1 = GetValidInput("Ange ett tal: ");
        }

        //Metod för att ta in data för två tal
        public void UserInputTwoValues(out double tal1, out double tal2)
        {
            tal1 = GetValidInput("Ange ett tal: ");
            tal2 = GetValidInput("Ange ett andra tal: ");
        }
        //Felhantering så att input från användare har rätt format
        private double GetValidInput(string prompt)
        {
            double result;

            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Ogiltigt format, vänligen ange ett tal.");
                }
            }
        }
       
        //Metod för att subtrahera två tal som skriver ut resultat till användare
        public void Substract(double sub1, double sub2)
        {
            Resultat = sub1 - sub2;
            Console.WriteLine($"{sub1} - {sub2} = {Resultat}");

        }
        //Metod för att addera två tal som skriver ut resultat till användare
        public void Addition(double tal1, double tal2)
        {

            Resultat = tal1 + tal2;
            Console.WriteLine($"Summan är {Resultat}");
        }
        //Metod för att multiplicera två tal som skriver ut resultat till användare
        public void Multiplicate(double mul1, double mul2)
        {
            Resultat = mul1 * mul2;
            Console.WriteLine($"{mul1} * {mul2} = {Resultat}");
        }
        //Metod för att dividera två tal som skriver ut resultat till användare
        public void Divide(double div1, double div2)
        {

            Resultat = div1 / div2;
            Console.WriteLine($"{div1} / {div2} = {Resultat}");
        }
        //Metod för "tal1 upphöjt med tal2" och skriver ut resultat till användare
        public void PowerOf(double po1, double po2)
        {
            Resultat = Math.Pow(po1, po2);
            Console.WriteLine($"{po1} ^ {po2} = {Resultat}");

        }
        //Metod för att kolla roten ur ett tal och skriver ut resultat till användare
        internal void SquareRoot(double squ1)
        {
            Resultat = Math.Sqrt(squ1);
            Console.WriteLine($"Roten ur {squ1} är: {Resultat}");
        }
    }//class calc end
}