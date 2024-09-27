
using System;

namespace EnkelKalkylator
{ 
    
    internal class Calculator
    {//class calc
        public double Tal1 { get; set; }
        public double Tal2 { get; set; }
        public double Resultat { get; set; }

        public void UserInput(out double tal1, out double tal2)
        {
            Console.WriteLine("Ange tal 1");
            tal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Angel tal 2");
            tal2 = Convert.ToDouble(Console.ReadLine());
        }

        public void Addition(double tal1,double tal2)
        {

            Resultat = tal1 + tal2;
            Console.WriteLine($"Summan är {Resultat}");
        }



    }//class calc end
}