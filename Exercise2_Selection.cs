using System;

namespace Exercise2_Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter your username.");
            
            string username = Console.ReadLine();
            
            if (username == "jambrose")
            {
                Console.WriteLine("Please enter your password");
                
                string password = Console.ReadLine();

                if (password == "potatoes")
                {
                    Console.WriteLine("Hang tight! We're logging you in.");
                    Console.WriteLine("You're in! Welcome.");

                }
                else
                {
                    Console.WriteLine("Password incorrect.");
                }

            }
            else if (username != "jambrose");
            {
                Console.WriteLine("Log in unsuccessful.");
            }


    


        }
    }
}
