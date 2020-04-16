// FILE: D:/New Folder (22)/UserPackage/StoreOwnerDataBase.cs

// In this section you can add your own using directives
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000976 begin
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000976 end
using System.Collections.Generic;

namespace UserPackage {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class StoreOwnerDataBase : IAddUserRepo, IUpdateUserRepo, IDeleteUserRepo, IListUserRepo, ISearchUserRepo
    {
       static private List<StoreOwner> storeOwners = new List<StoreOwner>
        {
            new StoreOwner("morsi@gmail.com","morsi","789"),
        };

        public /// <summary>
               ///  An operation that does...
               /// 
               ///  @param firstParam a description of this parameter
               /// </summary>
               /// <param name="StoreOwner">
               /// </param>
               /// <returns>
               /// </returns>
     void addUser(User user)
    {
            storeOwners.Add((StoreOwner)user);
            // section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:000000000000098F begin
            // section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:000000000000098F end
    }

    public /// <summary>
    ///  An operation that does...
    /// 
    ///  @param firstParam a description of this parameter
    /// </summary>
    /// <param name="String">
    /// </param>
    /// <returns>
    /// </returns>
      UserController searchByEmail(string email)
    {
            // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AF6 begin
            // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AF6 end
            foreach (User user in storeOwners)
            {
                if (user.getEmail().Equals(email))
                    return new StoreOwnerController((StoreOwner)user);
            }
            return null;
        }

    public /// <summary>
    ///  An operation that does...
    /// 
    ///  @param firstParam a description of this parameter
    /// </summary>
    /// <param name="StoreOwner">
    /// </param>
    /// <returns>
    /// </returns>
     void updateUser(User user)
    {
    // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AF9 begin
    // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AF9 end

    }

    public /// <summary>
    ///  An operation that does...
    /// 
    ///  @param firstParam a description of this parameter
    /// </summary>
    /// <param name="String">
    /// </param>
    /// <returns>
    /// </returns>
     void deleteUserByEmail(string email)
    {
    // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AFC begin
    // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AFC end

    }
        public List<User> listUsers()
        {
            return new List<User>(storeOwners);
        }

    } /* end class StoreOwnerDataBase */

}
