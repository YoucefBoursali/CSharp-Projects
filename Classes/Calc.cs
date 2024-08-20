using System;

namespace myProgram
{
    class Calculator
    {
        public void Calc ()
        {
            double num1, num2;
            char op = '\0';

            do
            {
                try
                {
                    Console.Write("Enter a number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter a second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    bool validOperator = false;
                    while (!validOperator)
                    {
                        Console.Write("Enter an operator (+, -, *, /): ");
                        op = Convert.ToChar(Console.ReadLine());

                        switch (op)
                        {
                            case '+':
                            case '-':
                            case '*':
                            case '/':
                                validOperator = true;
                                break;
                            default:
                                Console.WriteLine("Invalid operator. Please enter +, -, *, or /.");
                                break;
                        }
                    }

                    double result = 0;
                    switch (op)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                            }
                            else
                            {
                                Console.WriteLine("Error: Division by zero.");
                                continue; // Restart the outer loop to allow user to input valid numbers and operator again
                            }
                            break;
                    }
                    Console.WriteLine($"Result: {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter a valid number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is too large or too small.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("Press any key to continue or 'q' to quit.");
            } while (Console.ReadKey().Key != ConsoleKey.Q);
        }
    }
}