using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UserPackage;

namespace StorePackage
{


    public class OnlineStoreDataBase : IAddStoreRepo, IUpdateStoreRepo, IDeleteStoreRepo, ISearchStoreRepo, IListOwnerStores
    {
        static private SqlConnection conn = new SqlConnection("Data Source=sql5053.site4now.net;Initial Catalog=DB_A5A92A_SWEDB;Persist Security Info=True;User ID=DB_A5A92A_SWEDB_admin;Password=aaas2020;MultipleActiveResultSets=True");
        // Operations

        public void addStore(StoreController store)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into OnlineStore  values('" + store.getStoreName() + "','" + store.getStoreAddress() + "','" + store.getStoreOwner().getEmail() + "')";
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public StoreController searchStoreByName(string name)
        {
            conn.Open();
            string strSelect = "Select * From OnlineStore where storeName=@name";
            SqlCommand cmd = new SqlCommand(strSelect, conn);
            cmd.Parameters.Add("@name", name);
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                string storename = myReader["storeName"].ToString();
                string storeaddress = myReader["storeAddress"].ToString();
                string storeowner = myReader["storeOwner"].ToString();
                StoreOwnerDataBase sodb = new StoreOwnerDataBase();
                StoreOwnerController storeOwner = (StoreOwnerController)sodb.searchByEmail(storeowner);
                StoreController store = new OnlineStoreController(storename, storeaddress, storeOwner);
                conn.Close();
                return store;
            }
            conn.Close();
            return null;

        }

        public void updateStore(Store a)
        {
            //  return false;
            // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000B0A begin
            // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000B0A end

        }

        public void deleteStoreByName(string a)
        {
            //return false;
            // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000B0D begin
            // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000B0D end

        }
        public List<StoreController> listOwnerStores(string email)
        {
            bool wasOpen = true;
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
                wasOpen = false;
            }
            string strSelect = "Select * From OnlineStore where storeOwner=@email";
            SqlCommand cmd = new SqlCommand(strSelect, conn);
            cmd.Parameters.Add("@email", email);
            SqlDataReader myReader = cmd.ExecuteReader();
            List<StoreController> stores = new List<StoreController>();
            while (myReader.Read())
            {
                string storename = myReader["storeName"].ToString();
                string storeaddress = myReader["storeAddress"].ToString();
                string storeowner = myReader["storeOwner"].ToString();
                StoreOwnerDataBase sodb = new StoreOwnerDataBase();
                StoreOwnerController storeOwner = (StoreOwnerController)sodb.searchByEmail(storeowner);
                StoreController store = new OnlineStoreController(storename, storeaddress, storeOwner);
                stores.Add(store);
            }
            if(!wasOpen)
                conn.Close();
            return stores;
        }
    }

}
