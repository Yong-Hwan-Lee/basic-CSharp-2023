using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace number_5_app
{
    interface Animal
    {
        int Age { get; set; }
        string Name { get; set; }

        void Eat();
        void Sleep();
        void Sound();
    }
    class Dog : Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name}는 사료를 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name}는 엎드려서 잡니다.");
        }
        public void Sound()
        {
            Console.WriteLine($"{Name}는 멍멍하고 짓습니다.");
        }
    }
    class Cat : Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name}는 생선을 먹습니다.");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name}는 몸을 말고 잡니다.");
        }
        public void Sound()
        {
            Console.WriteLine($"{Name}는 야옹하고 웁니다");
        }
    }

    class Horse : Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine($"{Name}은/는 풀을 먹습니다.");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name}은/는 서서 잡니다.");
        }
        public void Sound()
        {
            Console.WriteLine($"{Name}은/는 히이힝 하고 웁니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog { Name = "바둑이", Age = 3 };
            Cat cat = new Cat { Name = "나비", Age = 5 };
            Horse horse = new Horse { Name = "골드쉽", Age = 7 };

            Console.WriteLine($"Dog name: {dog.Name}, age: {dog.Age}");
            dog.Eat();
            dog.Sleep();
            dog.Sound();

            Console.WriteLine($"Cat name: {cat.Name}, age: {cat.Age}");
            cat.Eat();
            cat.Sleep();
            cat.Sound();

            Console.WriteLine($"Horse name: {horse.Name}, age: {horse.Age}");
            horse.Eat();
            horse.Sleep();
            horse.Sound();

        }
    }
}
