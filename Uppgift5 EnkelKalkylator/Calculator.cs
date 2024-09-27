
namespace EnkelKalkylator
{
    internal class Calculator
    {//Internal class Calc
        public double Tal1 {  get; set; }
        public double Tal2 { get; set; }



        public Menu menu = new Menu();
        public Calculator()
        {
            

        }



        internal void Run()
        {
            menu.MainMenu();
        }
    }//Internal class Calc end
}