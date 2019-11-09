using System;

namespace TableOfPowers {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Table of Power App!");

            string cont = "y";
            while (cont.Equals("y")) {

                Console.Write("Enter a whole number.");

                int lenght = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\nNumber\t\tSquared\t\tCubed");
                Console.WriteLine("======\t\t =======\t\t =====");
                for (int i = 1; i <= lenght; i++) {
                    Console.WriteLine(i + "\t\t" + i * i + "\t\t" + i * i * i);
                }
                Console.Write("Continue? y/n: ");
                cont = Console.ReadLine();
            }
            Console.WriteLine("GoodBye");
        }
    }
}
