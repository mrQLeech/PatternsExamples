using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Client
    {
        public Client(IRoleManager manager)
        {
            var user = manager.GetUser();
            var role = manager.GetRoles(user);
            manager.DoSomething();
        }
    }
}
