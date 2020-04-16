using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserPackage;


namespace WebApplication3.Controllers
{

    /// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
    /// </summary>
    public class LoginController : ApiController, ILogin
    {
        private IUserFinder userFinder = new RegisteredUsersController();

        // Operations
        [HttpGet]
        public User login(string email, string password)
        {
            UserController user = userFinder.findUser(email);
            if (user == null || !user.getPassword().Equals(password))
                return null;

            Global.setSession(user);

            return user.getModel();
        }

       
    } /* end class Login */

}
