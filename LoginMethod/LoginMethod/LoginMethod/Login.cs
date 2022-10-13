using System;
using System.Collections.Generic;
using System.Text;

namespace LoginMethod
{
    class Login
    {

        public void LoginResult()
        {
            string username = "";

            string password = "";

            string fullname = username+password;

            fullname = Login1(username, password);

            if (fullname=="cavid123Cavid1993")
            {
                Console.WriteLine("Login was complate Successful");
            }
            else
            {
                Console.WriteLine("Your email or password not correct!");
            }
        }         

        public string Login1(string username, string passWord)
        {
            string fullname = "";

            username = Console.ReadLine();
            passWord = Console.ReadLine();

            

            fullname = username + passWord;
            
            return fullname;
            
        }

      
    }
}
