using System;

namespace DogApp
{
    public class Chihuahua : Dog
    {
        public Chihuahua(string dogName, string dogColor) : base(dogName, dogColor)
        {
        }

        public override void Bark()
        {
            Console.WriteLine("Yap!");
        }
    }
}