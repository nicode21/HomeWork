using System;
using System.Collections.Generic;
using System.Text;

namespace LoginMethod
{
    class Login
    {
        public Login(string username , string password)
        {
            if (username == "cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("Login was complate Successful");
            }
            else
            {
                Console.WriteLine("Your email or password not correct!");
            }
        }
    }
}
