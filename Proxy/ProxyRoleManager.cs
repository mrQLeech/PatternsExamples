using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyRoleManager : IRoleManager
    {
        private IRoleManager _roleManager;

        private IRoleManager RoleManager
        {
            get
            {
                if (_roleManager == null)
                {
                    _roleManager = new RealRoleManager();
                }
                return _roleManager;
            }
        }


        public void DoSomething()
        {
            Console.WriteLine("I do something through proxy");
            var user = RoleManager.GetUser();
            var rules = RoleManager.GetRoles(user);
            if (rules == "root")
            {
                Console.WriteLine("I can do something with users");

                RoleManager.DoSomething();
            }
            else
            {
                Console.WriteLine("I can't do something with users. Operation abort.");
            }
        }

        public string GetRoles(string user)
        {
            Console.WriteLine($"Use proxy to get roles to user {user}");
            return RoleManager.GetRoles(user);

        }

        public string GetUser()
        {
            Console.WriteLine("Use proxy to get user");
            return RoleManager.GetUser();
        }
    }
}
