using System;

namespace SnakeAndLadder

{
    class Snakeandladder
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Diceroll = random.Next(1, 7);


            int position = 0;
            Console.WriteLine("Welcome to Snake and Ladder");         
            Console.WriteLine("initial position is " + position);
            Console.WriteLine("Dice roll : " + Diceroll);
        }
    }
}
