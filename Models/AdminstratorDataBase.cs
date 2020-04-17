// FILE: D:/New Folder (22)/UserPackage/AdminstratorDataBase.cs

// In this section you can add your own using directives
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000974 begin
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000974 end
using System.Collections.Generic;

namespace UserPackage {




    public class AdminstratorDataBase : IAddUserRepo, IUpdateUserRepo, IDeleteUserRepo, IListUserRepo,ISearchUserRepo
{
        static private SqlConnection conn = new SqlConnection("Data Source=sql5053.site4now.net;Initial Catalog=DB_A5A92A_SWEDB;Persist Security Info=True;User ID=DB_A5A92A_SWEDB_admin;Password=aaas2020");
        List<Adminstrator> AdminUser = new List<Adminstrator>
        {
            new Adminstrator("suhail@gmail.com","suhail","456"),
        };



        // Operations

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <param name="Adminstrator">
        /// </param>
        /// <returns>
        /// </returns>
        public void addUser(User user)
        {     
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Adminstrator values('" + user.email + "','" + user.userName + "','" + user.password + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <param name="String">
        /// </param>
        /// <returns>
        /// </returns>
        public  UserController searchByEmail( string email)
    {
            foreach (User user in AdminUser)
            {
                if (user.getEmail().Equals(email))
                    return new AdminstratorController((Adminstrator)user);
            }
            return null;

        }

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <param name="Administrator">
        /// </param>
        /// <returns>
        /// </returns>
        public void updateUser( User a)
    {
           
    // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AE7 begin
    // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AE7 end

    }

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <param name="String">
        /// </param>
        /// <returns>
        /// </returns>
        public void deleteUserByEmail( string a)
    {
                // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AEA begin
    // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AEA end

    }

        public List<User> listUsers()
        {
            return new List<User>(AdminUser);
        }

        
    } /* end class AdminstratorDataBase */

}
