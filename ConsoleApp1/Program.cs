using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "admin";
            string password = "pass1234";
            string UserName, userpassword;
            int tries = 0;

            while(tries !=3)

            Console.WriteLine("enter your username: ");


            UserName = Console.ReadLine();
            Console.WriteLine("enter your password: ");
            userpassword = Console.ReadLine();

            if (login != UserName || password != userpassword)
                Console.WriteLine("Oops something went wrong");
            tries++;

        }
    }
}
