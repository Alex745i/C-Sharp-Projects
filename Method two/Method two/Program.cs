﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_two
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps FirstOp = new MathOps();
            Console.WriteLine("Please choose a number:");
            FirstOp.num1 = Convert.ToInt32(Console.ReadLine());

            try
            {

                Console.WriteLine("Select a second number. Press return if you do not want a second number will be auto populated:");
                int sum = FirstOp.MathMethod(FirstOp.num1, FirstOp.num2);
                Console.WriteLine(sum);
            }
            catch (FormatException)
            {
                FirstOp.num2 = 782;

            }


            Console.WriteLine("Thanks for checking out the program!");
            Console.ReadLine();



        }
    }
}