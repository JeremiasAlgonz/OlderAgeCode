using System;
using OlderAge.Entities;
using System.Collections.Generic;

namespace OlderAge
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            People olderP = new People();
            List<People> list = new List<People>();

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

                    Console.WriteLine("----------------------------------");
                    list.Add(new People(name, age));
                }

                

                foreach (var item in list)
                {
                    if (item.CompareTo(olderP) > 0)
                    {
                        olderP = item;
                    }

                }


                Console.WriteLine("The oldest among the people is:");
                people.ShowData(olderP);

                Console.WriteLine();
                Console.ReadLine();

            }
            catch(Exception e)
            {
                Console.WriteLine($"An unexpected error occurred! {e.Message}...");
            }
        }
    }
}
