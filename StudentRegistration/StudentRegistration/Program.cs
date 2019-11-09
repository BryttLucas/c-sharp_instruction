using System;

namespace StudentRegistration {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Student Registration!");

            Console.WriteLine("Enter first name: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("first name = " + str1);

            Console.WriteLine("Enter last name: ");
            string str2 = Console.ReadLine();
            Console.WriteLine("last name = " + str2);

            Console.WriteLine("Enter year of birth: ");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("birth = " + i1);

            Console.WriteLine(" Welcome " +(str1 + str2)+ "!\n" + " Your registion is complete.\n" + "Your temporary password is. " + ( str2 + i1 ));

        }
    }
}
