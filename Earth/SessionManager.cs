using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityData.Database;

namespace Earth
{
    public class SessionManager : ISessionManager
    {
        public object GetUserID()
        {
            return 1;
        }

        public bool IsUserLoggedIn()
        {
            return true;
        }
    }
}
