using System;
namespace ConsoleApp1 
{
    class Employee
    {
        private int employeeID;
        private string name;
        private string designation; 
        private double basicSalary;
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        } 
        public string Name 
        {
            get { return name; }
            set { name = value; }
        } 
        public string Designation 
        { get { return designation; }
            set { designation = value; }
        }
        public double BasicSalary
        { 
            get { return basicSalary; } 
            set { basicSalary = value; }
        }
        public void SetEmployeeDetails(int id, string empName, string empDesignation, double salary) 
        { 
            EmployeeID = id; Name = empName; Designation = empDesignation; BasicSalary = salary; 
        }
        public void GetEmployeeDetails() 
        { 
            Console.WriteLine("Employee ID: " + EmployeeID); Console.WriteLine("Name: " + Name);
            Console.WriteLine("Designation: " + Designation); Console.WriteLine("Basic Salary: " + BasicSalary);
        } 
    }
    class ContractorEmployee : Employee 
    { 
        private double transportAllowance;
        private double dearnessAllowance;
        private double houseRentAllowance;
        private double providentFund; private double otherTaxes; public double TransportAllowance 

        {
            get { return transportAllowance; } 
            set { transportAllowance = value; }
        }
        public double DearnessAllowance 
        {
            get { return dearnessAllowance; }
            set { dearnessAllowance = value; } 
        } 
        public double HouseRentAllowance 

        { 
            get { return houseRentAllowance; } 
            set { houseRentAllowance = value; } 
        } 
        public double ProvidentFund
        {
            get { return providentFund; } 
            set { providentFund = value; }
        }
        public double OtherTaxes 
        {
            get { return otherTaxes; } 
            set { otherTaxes = value; } 
        } 
        public double CalculateNetSalary() 
        { 
            double grossSalary = BasicSalary + TransportAllowance + DearnessAllowance + HouseRentAllowance; 
            double deductions = ProvidentFund + OtherTaxes; return grossSalary - deductions; 
        }
    } 
    class Class10
    {
        public static void Main(string[] args) 
        {
            ContractorEmployee contractor = new ContractorEmployee(); 
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name: "); 
            string name = Console.ReadLine();
            Console.Write("Enter Designation: "); 
            string designation = Console.ReadLine();
            Console.Write("Enter Basic Salary: ");
            double basicSalary = double.Parse(Console.ReadLine());
            contractor.SetEmployeeDetails(id, name, designation, basicSalary);
            Console.Write("Enter Transport Allowance: "); 
            contractor.TransportAllowance = double.Parse(Console.ReadLine());
            Console.Write("Enter Dearness Allowance: "); 
            contractor.DearnessAllowance = double.Parse(Console.ReadLine());
            Console.Write("Enter House Rent Allowance: "); 
            contractor.HouseRentAllowance = double.Parse(Console.ReadLine());
            Console.Write("Enter Provident Fund: "); 
            contractor.ProvidentFund = double.Parse(Console.ReadLine()); 
            Console.Write("Enter Other Taxes: "); 
            contractor.OtherTaxes = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEmployee Details:");
            contractor.GetEmployeeDetails();
            double netSalary = contractor.CalculateNetSalary();
            Console.WriteLine("Net Salary: " + netSalary); 
        } 
    } 
}