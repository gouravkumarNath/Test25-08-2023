using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Course { get; set; }
        public Person(string name, string course)
        {
            Name = name;
            Course = course;
        }
        public abstract void SayHello(); 
        public abstract void SayGoodbye();
    }
        class Student : Person 
        { 
            public Student(string name, string course) : base(name, course) 
            { } 
            public override void SayHello() 
            { 
                Console.WriteLine($"Student {Name} says: Hello!"); 
            } 
            public override void SayGoodbye() 
            { 
                Console.WriteLine($"Student {Name} says: Goodbye!"); 
            } 
        }
    class Teacher : Person
    { 
        public Teacher(string name, string course) : base(name, course) 
        { }
        public override void SayHello() 
        {
            Console.WriteLine($"Teacher {Name} says: Hello!"); 
        } 
        public override void SayGoodbye() 
        { 
            Console.WriteLine($"Teacher {Name} says: Goodbye!"); 
        } 
    }

    class Class5 
    {
        static void Main(string[] args) 
        { 
            Console.Write("Enter your name: "); string name = Console.ReadLine(); 
            Console.Write("Enter your course: "); string course = Console.ReadLine();
            Console.Write("Are you a student or a teacher? (student/teacher): "); 
            string role = Console.ReadLine(); Person person; if (role == "student") 
            {
                person = new Student(name, course);
            } 
            else if (role == "teacher")
            {
                person = new Teacher(name, course); 
            } 
            else
            { 
                Console.WriteLine("Invalid role."); return; 
            } 
            person.SayHello(); person.SayGoodbye(); }
    }

}
