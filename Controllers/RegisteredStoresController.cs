using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StorePackage
{
    public class RegisteredStoresController : ApiController
    {
        private IListOwnerStores[] listStoreRepos = new IListOwnerStores[] { new OnlineStoreDataBase(), new OnlineStoreDataBase()};
        public List<StoreController> listStoresOfOwner(string email)
        {
            List<StoreController> stores = new List<StoreController>();
       //     for (int i = 0; i < listStoreRepos.Length; i++)
           //     stores.AddRange(listStoreRepos[i].listOwnerStores(email));
            return stores;
        }
    }
}
