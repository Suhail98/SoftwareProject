// FILE: D:/New Folder (22)/UserPackage/Register.cs

// In this section you can add your own using directives
// section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AB7 begin
// section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AB7 end
using StorePackage;
using System.Web.Http;

namespace UserPackage
{

    /// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
public class RegisterController: ApiController, IRegister
{
      
        IUserFinder userFinder = new RegisteredUsersController();

        IAddUserRepo normalUserRepo = new NormalUserDataBase();
        IAddUserRepo storeOwnerRepo = new StoreOwnerDataBase();

        ISearchStoreRepo onlineStoreSearcher = new OnlineStoreDataBase();
        IAddStoreRepo onlineStoreAdder = new OnlineStoreDataBase();

        ISearchStoreRepo onsiteStoreSearcher = new OnSiteStoreDataBase();
        IAddStoreRepo onsiteStoreAdder = new OnSiteStoreDataBase();

        [HttpPost]
        public NormalUserController registerNormalUser(string email, string userName, string password, [FromBody]string value)
        {
            UserController user = userFinder.findUser(email);
            if (user != null)
                return null;

            NormalUserController normalUser = new NormalUserController(email, userName, password);
            normalUserRepo.addUser(normalUser.getNormalUser());
            return normalUser;
        }

        [HttpPost]
        public StoreOwnerController registerStoreOwnerForOnlineStore(string email, string userName, string password, string storeName, string storeURL, [FromBody]string value)
        {
            UserController user = userFinder.findUser(email);
            if (user != null)
                return null;

            Store store = onlineStoreSearcher.searchStoreByName(storeName);
            if (store != null)
                return null;

            StoreOwnerController storeOwnerUser = new StoreOwnerController(email, userName, password);
            OnlineStore onlineStore = new OnlineStore(storeName, storeURL, storeOwnerUser.getStoreOwner());
            onlineStoreAdder.addStore(onlineStore);
            storeOwnerRepo.addUser(storeOwnerUser.getStoreOwner());
            return storeOwnerUser;
        }

        [HttpPost]
        public StoreOwnerController registerStoreOwnerForOnSiteStore(string email, string userName, string password, string storeName, string storeAddress, [FromBody]string value)
        {
            UserController user = userFinder.findUser(email);
            if (user != null)
                return null;

            Store store = onsiteStoreSearcher.searchStoreByName(storeName);
            if (store != null)
                return null;

            StoreOwnerController storeOwnerUser = new StoreOwnerController(email, userName, password);
            OnSiteStore onSiteStore = new OnSiteStore(storeName, storeAddress, storeOwnerUser.getStoreOwner());
            onsiteStoreAdder.addStore(onSiteStore);

            storeOwnerRepo.addUser(storeOwnerUser.getStoreOwner());

            storeOwnerRepo.addUser(storeOwnerUser.getStoreOwner());          

            return storeOwnerUser;
        }


    } /* end class Register */

}