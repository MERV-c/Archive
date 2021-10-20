using System;

namespace Calculator
{
    class Calculator
    {
        static string method;
        static double input1, input2;

        public double Calc()                                                        //Choose which calculation type to use in program.
        {   
            if (method == "a") 
            {
                return input1 + input2; 
            }

            if (method == "b") 
            { 
                return input1 - input2;
            }

            if (method == "c") 
            { 
                return input1 * input2; 
            }
            return 0;
        }
          
        public void ErrorCheck()                                                    //Display this message when an input is invalid.
        {             
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!!!!!!!!!!!WRONG INPUT!!!!!!!!!!!!!");
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to menu...");
                Console.ReadKey();
                Console.Clear();
                Display();
        }

        public void Display()
        {     
            Console.Clear();                                                        //The main Menu.
            Console.ForegroundColor = ConsoleColor.Green;                           //Everything is cooler in green.
            Console.WriteLine("a. Add   " + "b. Subtract   " + "c. Multiply   ");
            Console.Write("Input: ");
            method = Console.ReadLine();
            Console.Clear();

            if (method != "a" && method != "b" && method != "c") { ErrorCheck(); }  //Checking for invalid input and retry for input.

            if (method == "a") { Console.WriteLine("Adding"); }                     //Deciding which text to use.
            if (method == "b") { Console.WriteLine("Subtract"); }                   //~~
            if (method == "c") { Console.WriteLine("Multiply"); }                   //~~

            Console.Write("input 1: ");                                             //First user input for the calculation.
            try { input1 = Convert.ToDouble(Console.ReadLine()); }                  //Converts user input from string to double.
            catch (FormatException) { ErrorCheck(); }                               //Checking for invalid input

            Console.Write("input 2: ");                                             //Second user input for the calculation.
            try { input2 = Convert.ToDouble(Console.ReadLine()); }                  //~~ 
            catch (FormatException) { ErrorCheck(); }                               //~~
                           
            Console.WriteLine("Total: {0}", Calc());
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to menu...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
        LOOP:                                                                       //Main program loop.
            Calculator c = new Calculator();                                        //Not sure what this does, but thanks stackoverflow.
            c.Display();
            goto LOOP;
        }
    }
}
