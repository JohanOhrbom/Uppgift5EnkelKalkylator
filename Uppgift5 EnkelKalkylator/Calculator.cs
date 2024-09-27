using System;
using System.Data;
using System.Threading.Channels;

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
            Console.WriteLine("Ange tal 2");
            tal2 = Convert.ToDouble(Console.ReadLine());
            return;
        }
        //Metod för att subtrahera två tal som skriver ut resultat till användare
        public void Substract(double sub1, double sub2) 
        {
            Resultat = sub1 - sub2;
            Console.WriteLine($"{sub1} - {sub2} = {Resultat}");

        }
        public void Addition(double tal1,double tal2)
        {

            Resultat = tal1 + tal2;
            Console.WriteLine($"Summan är {Resultat}");
        }
        //Metod för att multiplicera två tal som skriver ut resultat till användare
        internal void Multiplicate(double mul1, double mul2)
        {
            Resultat = mul1 * mul2;
            Console.WriteLine($"{mul1} * {mul2} = {Resultat}");
        }
    }//class calc end
}