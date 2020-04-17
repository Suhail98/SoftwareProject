// FILE: D:/New Folder (22)/UserPackage/AdminstratorDataBase.cs

// In this section you can add your own using directives
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000974 begin
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000974 end
using System.Collections.Generic;
using System.Data.SqlClient;

namespace UserPackage {




    public class AdminstratorDataBase : IAddUserRepo, IUpdateUserRepo, IDeleteUserRepo, IListUserRepo,ISearchUserRepo
{
        static private SqlConnection conn = new SqlConnection("Data Source=sql5053.site4now.net;Initial Catalog=DB_A5A92A_SWEDB;Persist Security Info=True;User ID=DB_A5A92A_SWEDB_admin;Password=aaas2020");
        public void addUser(User user)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Adminstrator values('" + user.email + "','" + user.userName + "','" + user.password + "')";
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public  UserController searchByEmail( string email)
    {
            conn.Open();
            string strSelect = "Select * From Adminstrator where email=@email";
            SqlCommand cmd = new SqlCommand(strSelect, conn);
            cmd.Parameters.Add("@email", email);
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                string Nemail = myReader["email"].ToString();
                string userName = myReader["userName"].ToString();
                string password = myReader["password"].ToString();
                AdminstratorController Admin = new AdminstratorController(Nemail, userName, password);
                conn.Close();
                return Admin;
            }
            conn.Close();
            return null;

        }

        
        public void updateUser( User a)
    {
           
  
    }
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
