using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lab05_exceptions
{
    internal class Animal
    {
        private int age;

        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age
        {
            get => age;
            set
            {
                if (value < 0)
                    throw new MyAnimalException();
                else
                    age = value;
            }
        }

        public Animal(string name = "", double weight = 0.0, int age = 0)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Полная информация о животном Animal");
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return Name + " " + Weight + " " + Age;
        }

        public override bool Equals(object? obj)
        {
            return obj is Animal animal &&
                   Name == animal.Name &&
                   Weight == animal.Weight &&
                   Age == animal.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Weight, Age);
        }

        internal virtual void Input()
        {
            Console.Write("Name = ");
            Name = Console.ReadLine() ?? "";
            Console.Write("Weight = ");
            Weight = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Age = ");
            Age = int.Parse(Console.ReadLine() ?? "0");
        }
    }
}
