using System;

namespace ConsoleApp1
{
    abstract class Vehicle
    {
        public string Make;
        public string Model;
        public double Mileage;
        public Vehicle(string make, string model, double mileage)
        {
            this.Make = make; this.Model = model;
            this.Mileage = mileage;
        }
        public abstract void StartEngine();
        public abstract void StopEngine();
    }
    class Car : Vehicle
    {
        public Car(string make, string model, double mileage) : base(make, model, mileage)
        { }
        public override void StartEngine()
        {
            Console.WriteLine($"Starting the car engine of {Make} {Model}.");
        }
        public override void StopEngine()
        {
            Console.WriteLine($"Stopping the car engine of {Make} {Model}.");
        }
    }
    class Motorcycle : Vehicle
    {
        public Motorcycle(string make, string model, double mileage) : base(make, model, mileage) { }
        public override void StartEngine()
        {
            Console.WriteLine($"Starting the motorcycle engine of {Make} {Model} with milage {Mileage}.");
        }
        public override void StopEngine()
        {
            Console.WriteLine($"Stopping the motorcycle engine of {Make} {Model} with {Mileage}.");
        }
    }
    class Class6
    {
        public static void Main(string[] args)
        {
            Console.Write("Choose a vehicle (1 for Car, 2 for Motorcycle): ");
            int choice = int.Parse(Console.ReadLine()); Console.Write("Enter your fav vehicle : ");
            string make = Console.ReadLine();
            Console.Write("Enter model number : ");
            string model = Console.ReadLine();
            Console.Write("Enter mileage : ");
            double mileage = double.Parse(Console.ReadLine());
            Vehicle vehicle; if (choice == 1)
            {
                vehicle = new Car(make, model, mileage);
            }
            else
            {
                vehicle = new Motorcycle(make, model, mileage);
            }
            Console.Write("Do you want to start the engine? (yes/no): ");

            string startChoice = Console.ReadLine();

            if (startChoice.ToLower() == "yes")
            {
                vehicle.StartEngine();

            Start: Console.Write("Do you want to stop the engine? (yes/no): ");

                string stopChoice = Console.ReadLine(); if (stopChoice.ToLower() == "yes")
                {
                    vehicle.StopEngine();
                }
                else if (stopChoice.ToLower() == "no")
                {
                    Console.WriteLine("Engine is still working.");
                    goto Start;
                }
                else
                {

                    Console.WriteLine("Sorry we can't help you...\nEngine seized.");
                }
            }
            else if (startChoice.ToLower() == "no")
            {
                Console.WriteLine("Thank you for visiting.");
            }
        }
    }
}