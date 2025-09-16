using MyReal01_AbstractFactory;
using System;
namespace MyReal01_AbstractFactory
{
    /// <summary>
    /// MainApp startup class for Real-World
    /// Abstract Factory Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            Family family = new Family(africa);
            family.RunFoodChain();
            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            family = new Family(america);
            family.RunFoodChain();
            // Wait for user input
            Console.ReadKey();
        }
    }
}