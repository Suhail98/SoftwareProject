using System.Data.SqlClient;
using UserPackage;

namespace StorePackage
{

    public class OnSiteStoreDataBase : IAddStoreRepo, IDeleteStoreRepo, ISearchStoreRepo, IUpdateStoreRepo
    {
        static private SqlConnection conn = new SqlConnection("Data Source=sql5053.site4now.net;Initial Catalog=DB_A5A92A_SWEDB;Persist Security Info=True;User ID=DB_A5A92A_SWEDB_admin;Password=aaas2020");
        // Operations

        public void addStore(Store store)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into OnSiteStore  values('" + store.getStoreName() + "','" + store.getStoreAddress() + "','" + store.getStoreOwner().email + "')";
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public Store searchStoreByName(string name)
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
                Store store = new Store(storename, storeaddress, (StoreOwner)storeOwner.getModel());
                conn.Close();
                return store;
            }
            conn.Close();
            return null;

        }

        public void updateStore(Store a) { }
        public void deleteStoreByName(string a) { }
    }

}
