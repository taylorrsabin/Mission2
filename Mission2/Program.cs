using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare all variables
            int rolls = 0;
            var rand = new Random();
            int dice1 = 0;
            int dice2 = 0;
            int diceSum = 0;
            int[] hist = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            double probability = 0;

            //Get number of rolls from user
            Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?: ");
            rolls = int.Parse(Console.ReadLine());

            //Print description of the simulator
            Console.WriteLine($"\nDICE ROLLING SIMULATION RESULTS:\nEach \"*\" represents 1% of the total number of rolls\nTotal number of rolls = {rolls}");

            //Roll each of the two dice and sum them together for the total dice roll for the inputted number of rolls. Incrememnt the dice roll number in the hist array
            for (int i = 0; i < rolls; i++)
            {
                dice1 = (rand.Next(1, 7) - 1);
                dice2 = (rand.Next(1, 7) - 1);
                diceSum = dice1 + dice2;
                hist[diceSum]++;
            }

            //Calculate the percentage roll of the total # of rolls for each possible roll. Print in the form of a histogram
            for (int i = 0; i < hist.Length; i++)
            {
                Console.Write($"\n{(i + 2)}: \t");
                probability = Math.Round((hist[i] / (double)rolls) * 100);
                for (int j = 0; j < probability; j++)
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine("\n\nThanks for using the dice throwing simulator\n\nGoodbye, Human!");

            //Ayyyyyy
        }
    }
}

