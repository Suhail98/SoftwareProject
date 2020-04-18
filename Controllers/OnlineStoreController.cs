using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserPackage;

namespace StorePackage
{
    public class OnlineStoreController : StoreController
    {
        private OnlineStore onlineStore;
        public OnlineStoreController(string storeName, string storeAddress, StoreOwnerController storeOwner)
        {
            onlineStore = new OnlineStore(storeName, storeAddress, storeOwner);
        }
        public override string getStoreName()
        {
            return onlineStore.getStoreName();
        }
        public override string getStoreAddress()
        {
            return onlineStore.getStoreAddress();
        }
        public override StoreOwnerController getStoreOwner()
        {
            return onlineStore.getStoreOwner();
        }
    }
}
