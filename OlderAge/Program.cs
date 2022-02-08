using System;
using OlderAge.Entities;

namespace OlderAge
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();

            try 
            {

                Console.Write("Enter value to register: How many people? ");
                int quantity = int.Parse(Console.ReadLine());

                for (int i = 1; i <= quantity; i++)
                {
                    Console.Write($"Enter people #{i} name: ");
                    string name = Console.ReadLine();
                    Console.Write($"Enter people #{i} age: ");
                    int age = int.Parse(Console.ReadLine());

                    people = new People(name, age);
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine($"An unexpected error occurred! {e.Message}...");
            }
        }
    }
}
