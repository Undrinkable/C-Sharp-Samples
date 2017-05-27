using System;

namespace DogApp
{
    public class Husky : Dog
    {
        public Husky(string dogName, string dogColor) : base(dogName, dogColor)
        {
        }

        public override void Bark()
        {
            Console.WriteLine("Howl!");
        }
    }
}