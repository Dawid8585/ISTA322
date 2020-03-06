using System;

namespace roulette
{
    class Bets
    {
        public int num { get; set; }
        public string color { get; set;}
        public static int Number()
        {
            
            int[] number = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 00 };
          
            Random rand = new Random();
            int index = rand.Next(number.Length);
            return index;
        }
        public static int RedKey()
        {
            int[] redKey = { 32, 19, 21, 25, 34, 27, 36, 30, 23, 5, 16, 1, 14, 9, 18, 7, 12, 3 };
            int RED = redKey[new Random().Next(0, redKey.Length)];
            return RED;
        }
        public static int BlackKey()
        {
            int[] blackKey = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int BLACK = blackKey[new Random().Next(0, blackKey.Length)];
            return BLACK;
        }
        public static string REDORBLACK()
        {
            string[] REDorBlack = { "RED", "BLACK" };
            string RoB = REDorBlack[new Random().Next(0, REDorBlack.Length)];
            return RoB;
        }
        public static int NumberColorB(int BLACK, int index)
        {
            if (index == BLACK)
            {
                Console.WriteLine("BLACK");
                return index;
            }
            else
                return index;
        }
        public static int NumberColorR(int RED, int index)
        {
            if (index == RED)
            {
                Console.WriteLine("RED");
                return index;
            }
            else
                return index;
        }









    }
}
