using System;
using System.Collections.Generic;
using System.Linq;

namespace BeginnerCrashCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // 🔹 Variables & Types
            int number = 10;
            string name = "Stas";
            bool isEngineer = true;
            double pi = 3.14;
            char letter = 'A';

            Console.WriteLine($"Name: {name}, Number: {number}, Pi: {pi}, Engineer: {isEngineer}");

            // 🔹 Control Flow
            if (number > 5)
                Console.WriteLine("Number is greater than 5");
            else
                Console.WriteLine("Number is 5 or less");

            switch (letter)
            {
                case 'A':
                    Console.WriteLine("Letter is A");
                    break;
                default:
                    Console.WriteLine("Letter is something else");
                    break;
            }

            // 🔹 Loops
            Console.WriteLine("For loop:");
            for (int i = 0; i < 3; i++)
                Console.WriteLine(i);

            Console.WriteLine("While loop:");
            int x = 0;
            while (x < 3)
            {
                Console.WriteLine(x);
                x++;
            }

            // 🔹 Methods
            int sum = Add(3, 7);
            Console.WriteLine($"Sum: {sum}");

            // 🔹 Classes and Objects
            var myCar = new Car { Brand = "BMW" };
            myCar.Honk();

            // 🔹 Inheritance & Polymorphism
            Animal dog = new Dog();
            dog.Speak();

            // 🔹 Collections
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            foreach (var n in names)
                Console.WriteLine($"Name: {n}");

            // 🔹 Exception Handling
            try
            {
                int bad = int.Parse("oops");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Handled exception: " + ex.Message);
            }

            // 🔹 LINQ
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var evens = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even numbers via LINQ:");
            evens.ForEach(Console.WriteLine);
        }

        static int Add(int a, int b) => a + b;
    }

    class Car
    {
        public string Brand;
        public void Honk() => Console.WriteLine($"The {Brand} says Beep!");
    }

    class Animal
    {
        public virtual void Speak() => Console.WriteLine("Animal speaks");
    }

    class Dog : Animal
    {
        public override void Speak() => Console.WriteLine("Dog barks");
    }
}
