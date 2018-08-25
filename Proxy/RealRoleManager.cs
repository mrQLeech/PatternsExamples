using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RealRoleManager : IRoleManager
    {        

        public void DoSomething()
        {
            Console.WriteLine("I do something with users");
        }

        public string GetRoles(string user)
        {
            Console.WriteLine($"use RealRoleManager to get roles to user {user}");
            if (user == "administrator")
            {
                return "root";
            }
            else
            {
                return "user";
            }
        }

        public string GetUser()
        {
            Console.WriteLine($"use RealRoleManager to get user");
            return "administrator";
        }
    }
}
