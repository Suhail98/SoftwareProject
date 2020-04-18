// FILE: D:/New Folder (22)/StorePackage/OnSiteStoreController.cs

// In this section you can add your own using directives
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000967 begin
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000967 end
using UserPackage;

namespace StorePackage {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class OnSiteStoreController : StoreController
{
    // Attributes

        private OnSiteStore onSiteStore;
        public OnSiteStoreController(string storeName, string storeAddress, StoreOwnerController storeOwner)
        {
            onSiteStore = new OnSiteStore(storeName, storeAddress, storeOwner);
        }
        public override string getStoreName()
        {
            return onSiteStore.getStoreName();
        }
        public override string getStoreAddress()
        {
            return onSiteStore.getStoreAddress();
        }
        public override StoreOwnerController getStoreOwner()
        {
            return onSiteStore.getStoreOwner();
        }
    } /* end class OnSiteStoreController */

}
