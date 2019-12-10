using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxceligentAptitude
{
    public class User
    {
        static List<string> userList = new List<string>();
        public void Add(string user)
        {
            userList.Add(user);
        }
        public int GetUsersCount()
        {
            return userList.Count;
        }
    }
}
