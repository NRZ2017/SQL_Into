using System;
using System.Collections.Generic;

namespace SQL_Login
{
    public class Account
    {
        public string Username;
        public string Password;

        public Account(string name, string pass)
        {
            Username = name;
            Password = pass;
        }
    }

    class Program
    {
        //create a dummy list of accounts
        //create simple login

        static void Main(string[] args)
        {
            //check how to use this stuff in .net core
            /*SqlConnection
            SqlCommand
            SqlDataAdapter*/

            List<Account> accounts = new List<Account>(); //dummy 
            accounts.Add(new Account("Ryan", "gg"));
            Console.WriteLine("Enter a Username");
            string user = Console.ReadLine();
            Console.WriteLine("Enter a Password");
            string pass = Console.ReadLine();
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Username == user)
                {
                    if (accounts[i].Password == pass)
                    {
                        Console.WriteLine("Access Granted");
                    }
                }
                else
                {
                    Console.WriteLine("Access Denied");
                }
            }

            //connect to sql
            //send sql a command
            //receive the result table
            //load table into a local variable (List<Account>)
            //check if the username/password 
            

            Console.ReadKey();


        }
    }
}
