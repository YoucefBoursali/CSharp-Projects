using System;


namespace myProgram 
{
    class Human
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                Console.WriteLine("Select which class you want to run: ");
                Console.WriteLine("Calculator(Press C)");
                Console.WriteLine("Food(Press F)");
                var input = Console.ReadKey(true);
                switch(input.Key)
                {
                    case ConsoleKey.C:
                        Calculator calc = new Calculator();
                        calc.Calc();
                        break;
                    case ConsoleKey.F:
                        Object food1 = new Object();
                        food1.review();
                        break;
                    default:
                        continue;
                }
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }while(Console.ReadKey().Key == ConsoleKey.Q || Console.ReadKey().Key==ConsoleKey.F);
        }
    }
}