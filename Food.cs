using System;
using System.Runtime.CompilerServices;

namespace myProgram 
{
    class Object
    {
        public List<string> foods = new List<string>(){"apple", "pizza","juice", "hamburger"};
        public List<string> conditions = new List<string>(){"bad", "mid","ok", "good"};
        public void review()
        {
        do
        {
        Random rng = new Random();
        int eat = rng.Next(foods.Count);
        int tasted = rng.Next(conditions.Count);
    
        Console.WriteLine($"this {foods[eat]} tasted {conditions[tasted]}!");
        }while(Console.ReadKey(true).Key == ConsoleKey.Spacebar);
        }
    }
}