using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creative variable of different data type 
            //initialize with a " defalut " value 
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            //assign  some value 
            firstName = "tom";
            lastName = "Thumb";
            age = 18;
            street = "123 Fourth Street";
            city = "xinchang";
            country = "China";
            long int2010 = 0;
            DateTimeKind int01 = default(DateTimeKind);
            int int05 = 0;
            birthDate = new DateTime(2010, 01, 05);

            //output to the console window 

            //use simple output with just variable name
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            //use placeholder styke 
            //method one
            Console.WriteLine(age + " "+"years old");
            //method two
            Console.WriteLine("{0} years old" , age);

            //use string concatenation 
            Console.WriteLine(street + "," + city + ", " + country);

            //use string interpolation
            // NOTE: This line of code only works with Visual Studio 2015 or C# 6.0 and later.
            Console.WriteLine($"Born on {birthDate}");
        
            Console.ReadKey(); 

        }
    }
}
