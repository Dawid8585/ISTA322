using System;

namespace roulette
{
    class Program
    {
        static void Main(string[] args)
        {

        start:

            int index = Bets.Number();
            //string RandomColor = Bets.Color();
            int RED = Bets.RedKey();
            int BLACK = Bets.BlackKey();
            string RoB = Bets.REDORBLACK();
            int Rindex = Bets.NumberColorR(RED, index);
            int Bindex = Bets.NumberColorB(BLACK, index);
            double UserBank = 0.0;
            Console.WriteLine("Select bet option type");
            Console.WriteLine($"Option1 : Low (1-18) or High (19-36)");
            Console.WriteLine($"Option2 : RED or BLACK");
            Console.WriteLine($"Option3 : Dozens row thirds, 1 – 12, 13 – 24, 25 – 36");            Console.WriteLine($"Option4 : Columns: first, second, or third columns");
            Console.WriteLine($"Option5 : Street: rows, e.g., 1/2/3 or 22/23/24");
            Console.WriteLine($"Option6 : Corner: at the intersection of any four contiguous numbers");
            Console.WriteLine($"Option7 : Split: at the edge of any two contiguous numbers");

          

            string UserOption = Convert.ToString(Console.ReadLine());
            GameFormat.Choice(UserOption, RED, BLACK, index, RoB, Bindex , Rindex, UserBank);
            // Console.WriteLine($"red is {RED} black is {BLACK} overall its {index}");
            Console.ReadKey();



            Console.WriteLine("Press ENTER to play again");
            Console.ReadKey();

            goto start;
        }

    }
}
