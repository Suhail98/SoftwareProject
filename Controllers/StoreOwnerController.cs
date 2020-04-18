// FILE: D:/New Folder (22)/UserPackage/StoreOwnerController.cs

// In this section you can add your own using directives
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000965 begin
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000965 end
using StorePackage;
using System;
using System.Collections.Generic;

namespace UserPackage
{

    /// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
    /// </summary>
    public class StoreOwnerController : UserController
    {
        // Attributes

        private StoreOwner storeOwner;


        public StoreOwnerController(StoreOwner storeOwner)
        {
            this.storeOwner = storeOwner;
        }

        public StoreOwnerController(string email, string userName, string password)
        {
            storeOwner = new StoreOwner(email, userName, password);
        }
        public StoreOwnerController(string email, string userName, string password,List<StoreController>stores)
        {
            storeOwner = new StoreOwner(email, userName, password,stores);
        }

        public override string getPassword()
        {
            return storeOwner.getPassword();
        }
        public override User getModel()
        {
            return storeOwner;
        }

        public StoreOwner getStoreOwner()
        {
            return storeOwner;
        }

        public void addStore(StoreController store)
        {
            storeOwner.addStore(store);
        }
        public override string getEmail()
        {
            return storeOwner.getEmail();
        }
        public override string getUserName()
        {
            return storeOwner.getUserName();
        }
    } /* end class StoreOwnerController */

}
