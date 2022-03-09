using System;

namespace SnakeAndLadder

{
    class Snakeandladder
    {
        static void Main(string[] args)
        {
            int position = 0;
            Random random = new Random();
            int Diceroll = random.Next(1, 7);
            Random checkOption = new Random();
            int Options = random.Next(0, 3);
            Console.WriteLine("initial position is " + position);
            Console.WriteLine("Dice roll : " + Diceroll);

            switch (Options)
            {
                case 0:
                    position = position;
                    Console.WriteLine("player remains at = 0");
                    break;

                case 1:
                    position = position + Diceroll;
                    Console.WriteLine("player movers ahead =" +Diceroll);
                    break;


                case 3:
                    position = position - Diceroll;
                    Console.WriteLine("player moves back =" + Diceroll );
                    break;

            }
            

        }
    }
}
