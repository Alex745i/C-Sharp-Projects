﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP

{
    class Program
    {
        static void Main(string[] args)
        {
            // DO WHILE LOOP
            Console.WriteLine("Whats my first name? go on, give it a guess.");
            string guessedName = Console.ReadLine();

            bool name = guessedName == "jon";

            do
            {
                switch (guessedName)
                {
                    case "jon":
                        Console.WriteLine("\nWow, you got it right, nice job.");
                        name = true;
                        break;

                    case "john":
                        Console.WriteLine("\nReally a silent h... no sir, close though.");
                        Console.WriteLine("\nLet's try this again. Whats my first name?");
                        guessedName = Console.ReadLine();
                        break;

                    case "bob":
                        Console.WriteLine("\nNo I'm not a bob.");
                        Console.WriteLine("\nLet's try this again. Whats my first name?");
                        guessedName = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("\nOne hint, my name is 3-5 letters long.");
                        Console.WriteLine("\nLet's try this again. Whats my first name?");
                        guessedName = Console.ReadLine();
                        break;
                }
            }
            while (!name);
            Console.ReadLine();


            // WHILE LOOP
            Console.WriteLine("Time to count to ten! Press enter to continue.");
            Console.ReadLine();
            int n = 0;

            while (n < 11)
            {
                Console.WriteLine(n);
                if (n == 4)
                {
                    Console.WriteLine("Half way there!");
                }
                n++;
            }
            Console.ReadKey();
        }
    }
}