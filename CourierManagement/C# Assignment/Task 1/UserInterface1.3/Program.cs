using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.Implement User Authentication 1. Create a login system for employees and customers using C#  
//control flow statements.  
namespace UserInterface1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample user credentials
            string username, password;

            // Input for username and password
            Console.Write("Enter username: ");
            username = Console.ReadLine();

            Console.Write("Enter password: ");
            password = Console.ReadLine();

            
            if (username.StartsWith("ADMIN"))
            {
                
                if (AuthenticateEmployee(username, password))
                {
                    Console.WriteLine("ADMIN login successful!");
                    
                }
                else
                {
                    Console.WriteLine("Invalid ADMIN credentials.");
                }
            }
            else if (username.StartsWith("CUST"))
            {
                
                if (AuthenticateCustomer(username, password))
                {
                    Console.WriteLine("Customer login successful!");
                    
                }
                else
                {
                    Console.WriteLine("Invalid customer credentials.");
                }

            }

            else
            {
                Console.WriteLine("Unknown user type. Please enter a valid username.");
            }

            Console.ReadKey();  
        }
        
        static bool AuthenticateEmployee(string username, string password)
        {
            
            if (username == "ADMIN1" && password == "ADMINPass")
            {
                return true;
            }
            return false;
        }
        
        static bool AuthenticateCustomer(string username, string password)
        {
            if (username == "CUST1" && password == "custPass")
            {
                return true;
            }
            return false;
        }
        
    }
}
