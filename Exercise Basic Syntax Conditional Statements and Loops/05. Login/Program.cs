using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";

            int failCounter = 0;

            for (int i = username.Length - 1; i >= 0; i--)

            {
                password += username[i];
            }

            string currentPassword = Console.ReadLine();

            while (currentPassword != password)
            {
                failCounter++;
                if (failCounter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");




                currentPassword = Console.ReadLine();


            }
            if (failCounter < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }




        }
    }
}
