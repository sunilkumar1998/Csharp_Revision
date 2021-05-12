using ProductProcessing.Databases;
using ProductProcessing.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProcessing.Auth
{
	class AuthManager
	{
        public static void AcceptLoginCreds()

        {
            bool validated = false;
            while (!validated)
            {
                Console.WriteLine("Enter Login Name");
                string loginname = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();

                validated =ValidateUser(loginname, password);
            }


        }

        private static bool ValidateUser(string loginName1, string password1)
        {
            //User user = new User();
            MenuManager mng = new MenuManager();
            Boolean found = false;


            foreach (var u in User._users)

            {
                if (loginName1 == u.LoginName)
                {
                    if (password1 == u.PassWord)
                    {
                        found = true;
                        Console.WriteLine("user found!");
                        if (u.UserType == "customer")
                        {
                            Console.WriteLine("user is customer");
                            mng.CreateMenu(u.UserType);
                        }
                        else if (u.UserType == "manager")
                        {
                            Console.WriteLine("user is Manager");
                            mng.CreateMenu(u.UserType);
                        }

                        break;
                    }
                }



            }
            if (!found)
            {
                Console.WriteLine("user not found!");
                Console.WriteLine("Enter Again \n");


            }



            return found;
        }
    }
}
