using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserPackage
{
    public static class Global
    {
        static UserController currentUser;

        public static void setSession(UserController user)
        {
            currentUser = user;
        }
        public static void releaseSession()
        {
            currentUser = null;
        }
    }
}