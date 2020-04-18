// FILE: D:/New Folder (22)/StorePackage/StoreController.cs

// In this section you can add your own using directives
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000966 begin
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000966 end
using System;
using UserPackage;

namespace StorePackage {

    /// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
    /// </summary>
    public abstract class StoreController
    {
        public abstract string getStoreName();
        public abstract string getStoreAddress();
        public abstract StoreOwnerController getStoreOwner();
    } /* end class StoreController */

}
