using System;


namespace Lexicon1
{
    class Program

    {
        static void Main()
        {
            bool running = true;
            while (running)
            {
                 running = Menu(); //Making the menu run as long as the program makes the user return to the beginning each time a case is returned
            }
        }
        static bool Menu()
        {
            double valuea;
            double valueb;

            Console.Clear();
            Console.WriteLine("Let's calculate numbers!");
            Console.WriteLine("\nEnter the value for 'a':");
            Console.Write(">");
            string input1 = Console.ReadLine();

            bool correctvalue = double.TryParse(input1, out valuea);
            while (!correctvalue) //Running a loop until the user enters a correct value
            {
                Console.WriteLine("Not a correct value for a.");
                Console.WriteLine("\nTry entering the value for 'a' again:");
                Console.Write(">");
                input1 = Console.ReadLine();
                correctvalue = double.TryParse(input1, out valuea);
            }

            Console.WriteLine("\nEnter the value for 'b':");
            Console.Write(">");
            string input2 = Console.ReadLine();

            bool correctvalue2 = double.TryParse(input2, out valueb);
            while (!correctvalue2)
            {
                Console.WriteLine("Not a correct valut fo b.");
                Console.WriteLine("\nTry entering the value for 'b' again:");
                Console.Write(">");
                input2 = Console.ReadLine();
                correctvalue2 = double.TryParse(input2, out valueb);
            }

            Console.Clear();
            Console.WriteLine("\nYou have entered a = " + valuea + " och b = " + valueb);
            Console.WriteLine("\nThe calculation methods");

            Console.WriteLine("\n1) Adding a+b");
            Console.WriteLine("2) Subtracting a-b");
            Console.WriteLine("3) Multiplying a*b");
            Console.WriteLine("4) Dividing a/b");
            Console.WriteLine("\nOr 0 to close the application!");

            Console.WriteLine("\nChoose method and press enter:");
            Console.Write(">");

            switch (Console.ReadLine()) //Using switch readline to require the correct input for respective choice
            {
                case "1":

                    Console.WriteLine("\nAnswer: a + b = " + Adding(valuea, valueb) + " for a = " + valuea + " and b = " + valueb);
                    Console.WriteLine("\nPress enter to make a new calculation.");
                    Console.ReadLine();

                    return true;

                case "2":

                    Console.WriteLine("\nAnswer: a - b = " + Subtracting(valuea, valueb) + " for a = " + valuea + " and b = " + valueb);
                    Console.WriteLine("\nPress enter to make a new calculation.");
                    Console.ReadLine();

                    return true;

                case "3":

                    Console.WriteLine("\nAnswer: a * b = " + Multiply(valuea, valueb) + " for a = " + valuea + " and b = " + valueb);
                    Console.WriteLine("\nPress enter to make a new calculation.");
                    Console.ReadLine();

                    return true;

                case "4":

                    bool correctvalue3;
                    while (valueb == 0) //Running a loop until the value is correct for division
                    {
                        Console.WriteLine("When using division, the value for 'b' cannot be zero. Try entering the value for 'b' again:");
                        Console.Write(">");
                        string input3 = Console.ReadLine();
                        correctvalue3 = double.TryParse(input3, out valueb);
                    }

                    Console.WriteLine("\nAnswer: a / b = " + Divide(valuea, valueb) + " for a = " + valuea + " and b = " + valueb);
                    Console.Write("\nPress enter to make a new calculation.");
                    Console.ReadLine();

                    return true;

                case "0":
                    return false;

                default:
                    return true; //Making the user always to return to the menu, unless typing the specific numbers 0-4
            }
        }


        //Methods with the different ways of calculating
        static double Adding(double valuea, double valueb)
        {
            return valuea + valueb;
        }
        static double Subtracting(double valuea, double valueb)
        {
            return valuea - valueb;
        }
        static double Multiply(double valuea, double valueb)
        {
            return valuea * valueb;
        }
        static double Divide(double valuea, double valueb)
        {
            return valuea / valueb;
        }

    }
}