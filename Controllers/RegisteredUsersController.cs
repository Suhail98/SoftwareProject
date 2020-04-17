using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UserPackage
{
    public class RegisteredUsersController : ApiController, IUserFinder, IListAllUsers
    {
        static private SqlConnection conn = new SqlConnection("Data Source=sql5053.site4now.net;Initial Catalog=DB_A5A92A_SWEDB;Persist Security Info=True;User ID=DB_A5A92A_SWEDB_admin;Password=aaas2020");
        private ISearchUserRepo[] searchUserRepos = new ISearchUserRepo[] { new AdminstratorDataBase(), new NormalUserDataBase(), new StoreOwnerDataBase() };
        private IListUserRepo[] listUserRepos = new IListUserRepo[] { new NormalUserDataBase(), new StoreOwnerDataBase() };

        public UserController findUser(string email)
        {
            UserController userController = null;
            for (int i = 0; i < searchUserRepos.Length; i++)
            {
                userController = searchUserRepos[i].searchByEmail(email);
                if (userController != null) break;
            }
            return userController;
        }

        [HttpGet]
        public List<User> listAllUsers()
        {
            if (Global.getCurrentSession() != null && Global.getCurrentSession().GetType() != typeof(AdminstratorController)) return null;

            List<User> clientUsers = new List<User>();
            for (int i = 0; i < listUserRepos.Length; i++)
                clientUsers.AddRange(listUserRepos[i].listUsers());
            return clientUsers;

        }
    }
}