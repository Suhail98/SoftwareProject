// FILE: D:/New Folder (22)/StorePackage/Store.cs

// In this section you can add your own using directives
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:000000000000096D begin
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:000000000000096D end
using UserPackage;

namespace StorePackage {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Store
{
    // Attributes


    private StoreOwner storeOwner;
        private string storeName;
        private string storeAddress;

        public Store(string storeName, string storeAddress, StoreOwner storeOwner)
        {
            this.storeName = storeName;
            this.storeAddress = storeAddress;
           this.storeOwner = storeOwner;
        }
        public string getStoreName()
        {
            return storeName;
        }
        public string getStoreAddress()
        {
            return storeAddress;
        }
        public StoreOwner getStoreOwner()
        {
            return storeOwner;
        }
        public void setStoreName(string storeName)
        {
            this.storeName = storeName;
        }
        public void setStoreAddress(string storeAddress)
        {
            this.storeAddress = storeAddress;
        }
        public void setStoreOwner(StoreOwner storeOwner)
        {
            this.storeOwner = storeOwner;
        }

    } /* end class Store */

}
