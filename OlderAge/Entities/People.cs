using System;


namespace OlderAge.Entities
{
    class People : IComparable
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

        public int CompareTo(object obj)
        {
            if (!(obj is People))
            {
                throw new Exception("Invalid Argument! Object is not a People object.");
            }

            People other = obj as People;
            return Age.CompareTo(other.Age);
        }
    }
}
