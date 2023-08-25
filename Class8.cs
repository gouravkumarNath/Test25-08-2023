using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    public class exceptionCheck : Exception 
    { 
        public exceptionCheck(string message) : base(message) 
        { } 
    }
    class Class8 
    {
        public static void Main() 
        {
            Console.WriteLine("Enter a number between 1 to 10"); 
            int num = Convert.ToInt32(Console.ReadLine()); 
            try 
            { 
                if (num < 1 || num > 10)
                { 
                    throw new exceptionCheck("Number out of range 1 to 10"); 
                } 
            }
            catch(FormatException) 
            { 
                Console.WriteLine("Number is not in the exact range");
            }
            catch (exceptionCheck ex)
            { 
                Console.WriteLine($"error:{ex.Message}");
            } 
        }
    }
}
