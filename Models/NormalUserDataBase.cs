using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Http;

namespace UserPackage {


public class NormalUserDataBase : ApiController,IAddUserRepo, IUpdateUserRepo, IDeleteUserRepo, IListUserRepo, ISearchUserRepo
    {
        static private SqlConnection conn = new SqlConnection("Data Source=sql5053.site4now.net;Initial Catalog=DB_A5A92A_SWEDB;Persist Security Info=True;User ID=DB_A5A92A_SWEDB_admin;Password=aaas2020;MultipleActiveResultSets=True");


        public void addUser(User user)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into NormalUser values('" + user.email + "','" + user.userName + "','" + user.password + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    public UserController searchByEmail( string email)
    {
            conn.Open();
            string strSelect = "Select * From NormalUser where email=@email";
            SqlCommand cmd = new SqlCommand(strSelect, conn);
            cmd.Parameters.Add("@email", email);
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                string Nemail = myReader["email"].ToString();
                string userName = myReader["userName"].ToString();
                string password = myReader["password"].ToString();
                NormalUserController normaluser = new NormalUserController(Nemail, userName, password);
                conn.Close();
                return normaluser;
            }
            conn.Close();
            return null;
        }

        public void updateUser(User user)
         {
            conn.Open();
            string sql = "update NormalUser set email= @user.email , userName = @user.userName , password = @user.password where email=@user.email";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@user.email", user.email);
            cmd.Parameters.Add("@user.userName", user.userName);
            cmd.Parameters.Add("@user.password", user.password);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
         }

        public  void deleteUserByEmail(string email)
        {
            conn.Open();
            string sql = "delete from NormalUser where email=@email";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@email",email);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        public List<User> listUsers()
        {
            List<NormalUser> normalUsers = new List<NormalUser> ();
            conn.Open();
            string strSelect = "Select * From NormalUser ";
            SqlCommand cmd = new SqlCommand(strSelect, conn);
            SqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                NormalUser normalUser = new NormalUser();
                normalUser.email = myReader["email"].ToString();
                normalUser.userName = myReader["userName"].ToString();
                normalUser.password = myReader["password"].ToString();
                normalUsers.Add(normalUser); 
            }
            myReader.Close();
            conn.Close();
            return new List<User>(normalUsers);
        }
    } 

}
