/*
Name: Sasa Subotic
Date: 9/17/2019
Class: ISM 4300
Project Name: Deliverable 3, Methods
*/

using System;

namespace Deliverable_3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("System Date/Time: " + DateTime.Now + Environment.NewLine);
            Console.Write("Please enter your Name: ");


            {
                string nameinput = Console.ReadLine();
                double Num;
                bool isNum = double.TryParse(nameinput, out Num);

                if (isNum)
                {
                    OtherInput(isNum);
                }
                else
                {
                    CorrectText(nameinput);
                }
            } 
        }

        //creates a method for an string input
        private static string CorrectText(string nameinput)
        {
            //This input the string into a console writeline method
            Console.WriteLine("Hello " + nameinput + "! Welcome to my Methods project!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
            return nameinput;
        }

        //creates a method for an integer or decimal input
        private static void OtherInput(bool isNum)
        {
            Console.WriteLine("Please enter a name as this is not a name, thank you!");
            Console.WriteLine("Press any key to exit the program ...");
            Console.ReadKey(true);
        } 
    } 
} 