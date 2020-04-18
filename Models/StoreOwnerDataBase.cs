// FILE: D:/New Folder (22)/UserPackage/StoreOwnerDataBase.cs

// In this section you can add your own using directives
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000976 begin
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000976 end
using StorePackage;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace UserPackage {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class StoreOwnerDataBase : IAddUserRepo, IUpdateUserRepo, IDeleteUserRepo, IListUserRepo, ISearchUserRepo
    {
        static private SqlConnection conn = new SqlConnection("Data Source=sql5053.site4now.net;Initial Catalog=DB_A5A92A_SWEDB;Persist Security Info=True;User ID=DB_A5A92A_SWEDB_admin;Password=aaas2020;MultipleActiveResultSets=True");
        public void addUser(User user)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into StoreOwner values('" + user.email + "','" + user.userName + "','" + user.password + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    public  UserController searchByEmail(string email)
    {
            bool wasOpen = true;
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
                wasOpen = false;
            }
            string strSelect = "Select * From StoreOwner where email=@email";
            SqlCommand cmd = new SqlCommand(strSelect, conn);
            cmd.Parameters.Add("@email", email);
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {

                string Nemail = myReader["email"].ToString();
                string userName = myReader["userName"].ToString();
                string password = myReader["password"].ToString();
                List<StoreController> stores = new RegisteredStoresController().listStoresOfOwner(email);
                StoreOwnerController storeOwner = new StoreOwnerController(email, userName, password, stores); conn.Close();
                return storeOwner;
            }
            if(!wasOpen)
                conn.Close();
            return null;
        }

    public void updateUser(User user)
    {
            conn.Open();
            string sql = "update StoreOwner set email= @user.email , userName = @user.userName , password = @user.password where email=@user.email";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@user.email", user.email);
            cmd.Parameters.Add("@user.userName", user.userName);
            cmd.Parameters.Add("@user.password", user.password);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

        }

         public void deleteUserByEmail(string email)
          {
            conn.Open();
            string sql = "delete from StoreOwner where email=@email";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@email", email);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();

          }
        public List<User> listUsers()
        {
            List<StoreOwner> StoreOwners = new List<StoreOwner>();
            bool wasOpen = true;
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
                wasOpen = false;
            }
            string strSelect = "Select * From StoreOwner ";
            SqlCommand cmd = new SqlCommand(strSelect, conn);
            SqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {


                string email = myReader["email"].ToString();
                string userName = myReader["userName"].ToString();
                string password = myReader["password"].ToString();
                List<StoreController> stores = new RegisteredStoresController().listStoresOfOwner(email);
                StoreOwner storeOwner = new StoreOwner(email,userName,password,stores);
                StoreOwners.Add(storeOwner);
            }
            myReader.Close();
            if(!wasOpen)
                conn.Close();
            return new List<User>(StoreOwners);
        }
    } 

}
