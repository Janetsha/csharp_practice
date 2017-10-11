using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string response = "yes";
            if (response == "yes")
            {
                Console.writeline(response);
                Console.readline();
            }
            else
            {
                Console.writeline("no");
                Console.readline();
            }


            string homework = "homework";
            switch (homework)
            {
                case "connection_failed":
                    //Block of code executes if the value of response is "connection_failed".
                    break;
                case "connection_success":
                    // Block of code executes if the value of response is "connection_success".
                    break;
                case "connection_error":
                    // Block of code executes if the value of response is "connection_error".
                    break;
                default:
                    // Block executes if none of the above conditions are met.
                    break;
            }

        }
    }
}
