using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

// FILE: D:/New Folder (22)/UserPackage/IRegister.cs

// In this section you can add your own using directives
// section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AB4 begin
// section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AB4 end
namespace UserPackage {

/// <summary>
    ///  An interface defining operations expected of ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public interface IRegister
{
    // Operations

     /// <summary>
    ///  An operation that does...
    /// 
    ///  @param firstParam a description of this parameter
    /// </summary>
    /// <param name="String">
    /// </param>
    /// <param name="String">
    /// </param>
    /// <param name="String">
    /// </param>
    /// <returns>
    /// </returns>
         NormalUserController registerNormalUser( string a,  string b,  string c , [FromBody]string value);
         StoreOwnerController registerStoreOwnerForOnlineStore(string email, string userName, string password, string storeName, string storeAddress, [FromBody]string value);
         StoreOwnerController registerStoreOwnerForOnSiteStore(string email, string userName, string password, string storeName, string storeAddress, [FromBody]string value);


} /* end interface IRegister */

}
