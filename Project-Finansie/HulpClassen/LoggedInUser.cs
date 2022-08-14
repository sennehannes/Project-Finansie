using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Finansie.HulpClassen
{
    public static class LoggedInUser
    {
        private static string _loggedInUser;
        public static string loggedInUser
        {
            get { return _loggedInUser; }
            set
            {
                _loggedInUser = value;
            }
        }

    }
}
