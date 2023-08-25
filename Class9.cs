using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   // using System;
    class Customer 
    { 
        private string name; 
        private int age; 
        private string address; 
        public string Name
        { 
            get { return name; }
            set { name = value; }
        }
        public int Age 
        { get { return age; } 
            set { age = value; }
        } 
        public string Address
        { 
            
            get { return address; } 
            set { address = value; } 
        } 
        public Customer(string name, int age) 
        { this.Name = name; this.Age = age; } }
    class PremiumCustomer : Customer
    { 
        private double discountPercentage;
        public double DiscountPercentage 
        {
            get { return discountPercentage; }
            set { discountPercentage = value; } 
        }
        public PremiumCustomer(string name, int age, string address, double discountPercentage) : base(name, age) 
        {
            Address = address; DiscountPercentage = discountPercentage; 
        }
    }
    class Class9 { 
        public static void Main(string[] args) 
        { 
            Console.Write("Enter Customers name: "); 
            string name = Console.ReadLine(); 
            Console.Write("Enter Customers age: "); 
            int age = int.Parse(Console.ReadLine());
            Customer customer = new Customer(name, age);
            Console.WriteLine($"Customer: {customer.Name}, Age: {customer.Age}"); 
            Console.Write("Enter address of the customer: "); 
            string address = Console.ReadLine(); 
            Console.Write("Enter discount percentage you want: "); 
            double discountPercentage = double.Parse(Console.ReadLine()); 
            PremiumCustomer premiumCustomer = new PremiumCustomer(name, age, address, discountPercentage); 
            Console.WriteLine($"Premium Customer Details: {premiumCustomer.Name}, Age: {premiumCustomer.Age}, Address: {premiumCustomer.Address}, Discount: {premiumCustomer.DiscountPercentage}%");
        }
    }
}
