using System;
using System.Collections.Generic;
using System.Text;


 namespace MyConsole {
    class  MyConsole {
        public static string GetString(string prompt) {
            Console.WriteLine(prompt);
            string name = Console.ReadLine();
            return name;
        }
        public static int GetInt(string prompt) {
            int i = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                string s = Console.ReadLine();
                try {
                    i = Convert.ToInt32(s);
                    success = true;
                }
                catch (FormatException) {
                    Console.WriteLine("Error. Invalid entry!" + s);
                }
            }
            return i;
        }
        public static double GetDouble(string prompt) {
            double d = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                string s = Console.ReadLine();
                try {
                    d = Convert.ToInt32(s);
                    success = true;
                }
                catch (FormatException) {
                    Console.WriteLine("Error. Invalid entry!" + s);
                }
            }
            return d;
        }

        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override string ToString() {
            return base.ToString();
        }
    }  
 }

