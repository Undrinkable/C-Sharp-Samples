using System;

namespace DogApp
{
    public class Dog
    {
        public string Color { get; }

        public string Name { get; }

        public Dog(string dogName, string dogColor)
        {
            Name = dogName;
            Color = dogColor;
        }

        public virtual void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }
}