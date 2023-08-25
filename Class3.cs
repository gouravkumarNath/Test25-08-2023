using System;

namespace ConsoleApp1
{
     abstract class Animals
    {
        public string Name { get; set; }
        public Animals(string name)
        {
            Name = name;
        }
        public abstract void Roar();
        public abstract void Sprint();
    }
    class Cats : Animals
    {
        public Cats(string name) : base(name)
        { }
        public override void Roar()
        {
            Console.WriteLine($"{Name} is roaring");
        }
        public override void Sprint()

        {
            Console.WriteLine($"{Name} is sprinting");
        }
    }
    class Dogs : Animals
    {
        public Dogs(string name) : base(name)
        { }
        public override void Roar()
        {
            Console.WriteLine($"{Name} is roaring");
        }
        public override void Sprint()
        {
            Console.WriteLine($"{Name} is sprinting");
        }
    }
    class Class3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose animal");
            Console.WriteLine("1.Cat"); Console.WriteLine("2.Dog");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            Animals animal;
            if (choice == 1)
            {
                Console.WriteLine("Enter cat name");
                string name = Console.ReadLine();    
                animal = new Cats(name);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter Dog name");
                string name = Console.ReadLine();
                animal = new Dogs(name);
            }
            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }
            animal.Roar();
            animal.Sprint();
        }
    }
}