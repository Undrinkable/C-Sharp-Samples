using System;

namespace DogApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your dog?");
            string dogName = Console.ReadLine();
            Console.WriteLine("What color is the dog?");
            string dogColor = Console.ReadLine();
            Console.WriteLine("What kind of dog is he?");
            Console.WriteLine("0 - Chihuahua");
            Console.WriteLine("1 - Greyhound");
            Console.WriteLine("2 - Husky");
            string input = Console.ReadLine();

            Dog dog;
            if (input == "0")
            {
                dog = new Chihuahua(dogName, dogColor);
            } else if (input == "1")
            {
                dog = new GreyHound(dogName, dogColor);
            } else if (input == "2")
            {
                dog = new Husky(dogName, dogColor);
            } else
            {
                dog = new Dog(dogName, dogColor);
            }

            Console.WriteLine("Here comes {0}!", dog.Name);
            dog.Bark();

            Console.WriteLine();
            Console.WriteLine("Bye now.");
            Console.ReadKey();

        }
    }
}