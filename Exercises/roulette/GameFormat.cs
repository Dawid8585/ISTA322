using System;
using System.Collections.Generic;
using System.Text;

namespace roulette
{
    class GameFormat
    {
        double UserBank = 0.0;
        public static void Choice(string UserOption, int RED, int BLACK, int index, string RoB, int Bindex, int Rindex, double UserBank)
        {
            Console.WriteLine(UserBank);

            string op1 = "Option1";
            string op2 = "Option2";
            string op3 = "Option3";
            string op4 = "Option4";
            string op5 = "Option5";
            string op6 = "Option6";

            if (UserOption == op1)
            {
                do
                {
                    Console.WriteLine("Do you want to bet LOW or HIGH");
                    string LH = Convert.ToString(Console.ReadLine());


                    if (index >= 19)
                    {
                        do
                        {
                            Console.WriteLine(index);
                            if (LH == "LOW")
                            {
                                Console.WriteLine("YOU LOSE TRY AGAIN");
                                break;
                            }
                            else if (LH == "HIGH")
                            {
                                Console.WriteLine("YOU WIN");
                                break;
                            }
                            else
                                break;
                        }
                        while (index >= 19);
                    }
                    else if (index <= 18)
                    {
                        do
                        {
                            Console.WriteLine(index);
                            if (LH == "LOW")
                            {
                                Console.WriteLine("YOU WIN");
                                break;
                            }
                            else if (LH == "HIGH")
                            {
                                Console.WriteLine("YOU LOSE TRY AGAIN");
                                break;
                            }
                            else
                                break;
                        }
                        while (index >= 18);
                    }
                    else
                        Console.WriteLine("You Lose");
                    break;
                } while (UserOption == op1);
            }
            else if (UserOption == op2)
            {
                Console.WriteLine("Choose what color to bet on");
                string USERREDBLACK = Convert.ToString(Console.ReadLine());
                string Red = "RED";
                string Black = "BLACK";
                Console.WriteLine("User bet on " + USERREDBLACK);
                Console.WriteLine($"The ball spins and lands on ");
                if (USERREDBLACK == Red)
                {
                    do
                    {
                        if (RoB == Red)
                        {
                            Console.WriteLine(Rindex + " RED\n");

                            Console.WriteLine("YOU WIN");
                            break;
                        }
                        else if (Black == RoB)
                        {
                            Console.WriteLine(Bindex + " BLACK\n");
                            Console.WriteLine("YOU WIN");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("YOU LOSE");
                            break;
                        }
                    } while (USERREDBLACK == Red);
                }
                else if (USERREDBLACK == Black)
                {
                    do
                    {
                        if (Red == RoB)
                        {
                            Console.WriteLine(Rindex + " RED\n");

                            Console.WriteLine("YOU WIN");
                            break;
                        }
                        else if (Black == RoB)
                        {
                            Console.WriteLine(Bindex + " BLACK\n");
                            Console.WriteLine("YOU WIN");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("YOU LOSE");
                            break;
                        }
                    } while (USERREDBLACK == Black);

                }
                else
                    Console.WriteLine("Enter BLACK or RED");




            }
            else if (UserOption == op3)
            {
                //Option3: Dozens row thirds, 1 – 12, 13 – 24, 25 – 36
                do
                {
                    Console.WriteLine("Type A for 1-12 B for 13 - 24 C for 25 - 36");
                    string Third = Convert.ToString(Console.ReadLine());


                    if (index >= 1 && index <= 12)
                    {
                        do
                        {
                            Console.WriteLine(index);
                            if (Third == "A")
                            {
                                Console.WriteLine("YOU WIN");
                                break;
                            }
                            else if (Third == "B")
                            {
                                Console.WriteLine("YOU LOSE TRY AGAIN");
                                break;
                            }
                            else
                                break;
                        }
                        while (index >= 1);
                    }
                    else if (index >= 13 && index <= 24)
                    {
                        do
                        {
                            Console.WriteLine(index);
                            if (Third == "B")
                            {
                                Console.WriteLine("YOU WIN");
                                break;
                            }
                            else if (Third == "A")
                            {
                                Console.WriteLine("YOU LOSE TRY AGAIN");
                                break;
                            }
                            else
                                Console.WriteLine("YOU LOSE TRY AGAIN");
                            break;

                        }
                        while (index >= 13);
                    }
                    else if (index >= 25 && index <= 36)
                    {
                        do
                        {
                            Console.WriteLine(index);
                            if (Third == "C")
                            {
                                Console.WriteLine("YOU WIN");
                                break;
                            }
                            else if (Third == "B")
                            {
                                Console.WriteLine("YOU LOSE TRY AGAIN");
                                break;
                            }
                            else
                                Console.WriteLine("YOU LOSE TRY AGAIN");
                            break;

                        }
                        while (index >= 25 && index <= 36);

                    }

                    else

                    { Console.WriteLine(); }
                    break;
                } while (UserOption == op3) ;
                        
            }
            else if (UserOption == op4)
            {
                //Option4 : Columns: first, second, or third columns
            }
        }
    }
}          
                    // Console.WriteLine("Enter your bet");
                    // int UserBet = Convert.ToInt32(Console.ReadLine());