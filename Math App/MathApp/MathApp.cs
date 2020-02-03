using MathAppLibrary;
using System;

namespace MathApp

{
    class MathApp
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            double input1;
            double input2;
            string prompt = "\nPlease enter 2 numbers.\n";
            bool valid;
            bool newCalculation = false;
            string choice;


            do
            {
                Console.WriteLine("\nPlease type and enter the desired calculation.\n");

                Console.WriteLine("1. ADD");
                Console.WriteLine("2. SUBTRACT");
                Console.WriteLine("3. MULTIPLY");
                Console.WriteLine("4. DIVIDE\n");

                choice = Console.ReadLine();
                
                if (choice.ToUpper() == "ADD")
                {
                    try
                    {
                        Console.WriteLine(prompt);
                        input1 = Double.Parse(Console.ReadLine());
                        input2 = Double.Parse(Console.ReadLine());

                        Console.WriteLine($"{input1} + {input2} = {calc.Add(input1, input2)}");
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("\nInvalid input!");
                    }

                }
                else if (choice.ToUpper() == "SUBTRACT")
                {
                    try
                    {
                        Console.WriteLine(prompt);
                        input1 = Double.Parse(Console.ReadLine());
                        input2 = Double.Parse(Console.ReadLine());

                        Console.WriteLine($"{input1} - {input2} = {calc.Subtract(input1, input2)}");
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("\nInvalid input!");
                    }
                }
                else if (choice.ToUpper() == "MULTIPLY")
                {
                    try
                    {
                        Console.WriteLine(prompt);
                        input1 = Double.Parse(Console.ReadLine());
                        input2 = Double.Parse(Console.ReadLine());

                        Console.WriteLine($"{input1} * {input2} = {calc.Multiply(input1, input2)}");
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("\nInvalid input!");
                    }
                }
                else if (choice.ToUpper() == "DIVIDE")
                {
                    try
                    {
                        Console.WriteLine(prompt);
                        input1 = Double.Parse(Console.ReadLine());
                        input2 = Double.Parse(Console.ReadLine());

                        if (input2 == 0)
                        {
                            valid = false;
                            while (valid == false)
                            {
                                Console.WriteLine("0 is not a valid choice! Please try again.");
                                input2 = Double.Parse(Console.ReadLine());

                                if (input2 == 0)
                                {
                                    valid = false;
                                }
                                else
                                {
                                    valid = true;
                                }

                            }
                        }
                        else
                        {
                            valid = true;
                        }

                        Console.WriteLine($"{input1} / {input2} = {calc.Divide(input1, input2)}\n");
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("\nInvalid input!");
                    }
                }

              
                Console.WriteLine("\nType and enter RESTART to go again.");
                Console.WriteLine("\nOr press any key to exit.");

                if (Console.ReadLine().ToUpper() == "RESTART")
                    {
                        newCalculation = true;
                    }
                    else
                    {
                        newCalculation = false;
                    }
                
                
            
            } while (newCalculation == true);

            Console.WriteLine("Thanks for stopping by!");
            Console.ReadLine();
            
            
        }
    }
}
