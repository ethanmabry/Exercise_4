﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringVariables
{

    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            double myDouble = 5.5;
            string myString = "Hello";
            bool myBool = false;
            char myChar = 'e';

            Console.WriteLine("The value of my int is {0}", myInt);

            Console.WriteLine("The value of my int is " + myInt + " and the value of my double is " + myDouble);
        }
    }
}