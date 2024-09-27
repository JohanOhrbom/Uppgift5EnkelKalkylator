
namespace EnkelKalkylator
{
    public class Menu
    {
        public Menu()
        {
        }

        internal void MainMenu()
        {
            Console.WriteLine(" ---- Miniräknare ---- \n" +
                "\n\tVälj en av följande operationer för vad du önskar att göra:" +
                "\n\t1. Addera" +
                "\n\t2. Subtrahera" +
                "\n\t3. Dividera" +
                "\n\t4. Multiplicera" +
                "\n\t0. Avsluta programmet");
        }
    }
}