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

        public override bool Equals(object obj)
        {
            if (!(obj is People))
            {
                throw new Exception("Invalid argument! Object is not People.");
            }

            People other = obj as People;
            return Age.Equals(other.Age);
        }
    }
}
