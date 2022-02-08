using System;


namespace OlderAge.Entities
{
    class People
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public People()
        {

        }

        public People(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowData(People obj)
        {
            People other = obj as People;
            Console.WriteLine($"{other.Name}, {other.Age}.");
        }
    }
}
