using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProcessing.Databases
{
	public class User
	{
		public string LoginName { get; set; }
		public string PassWord { get; set; }
		public string UserType { get; set; }

        public static List<User> _users = new List<User>() {

            new User
            {
               LoginName="alex",
               PassWord="123",
               UserType="customer"
            },
            new User
            {
               LoginName="andy",
               PassWord="456",
               UserType="customer"
            },

            new User
            {
               LoginName="erik",
               PassWord="789",
               UserType="manager"

            },

        };
    }
}
