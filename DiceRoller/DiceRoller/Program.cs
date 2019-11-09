using System;

namespace DiceRoller {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Dice Roller");
            Console.Write("Do you want to roll the dice? y/n");

            string rollDice = Console.ReadLine();
            while (rollDice.Equals("y")) {
                Random random = new Random();
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                if (dice1 + dice2 == 2) {
                    Console.WriteLine(" Dice 1 =" + dice1);
                    Console.WriteLine(" Dice 2 =" + dice2);
                    Console.WriteLine("Total is " + (dice1 + dice2) + "  Snake Eyes");
                }
                else if (dice1 + dice2 == 12) {
                    Console.WriteLine(" Dice 1 =" + dice1);
                    Console.WriteLine(" Dice 2 =" + dice2);
                    Console.WriteLine(" Total  is " + (dice1 + dice2 + "  Box Car."));
                }
                else {
                    Console.WriteLine(" Dice 1 ="  + dice1);
                    Console.WriteLine(" Dice 2 ="  + dice2);
                    Console.WriteLine(" Total  = " + (dice1 + dice2));
                }
              Console.Write("Play again?  y/ n ");
              rollDice = Console.ReadLine();

            }
        Console.WriteLine("  Thanks for playing Goodbye. ");
        }
    }
} 
