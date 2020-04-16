// FILE: D:/New Folder (22)/UserPackage/NormalUserDataBase.cs

// In this section you can add your own using directives
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000975 begin
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000975 end
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace UserPackage {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class NormalUserDataBase : ApiController,IAddUserRepo, IUpdateUserRepo, IDeleteUserRepo, IListUserRepo, ISearchUserRepo
    {
       static private List<NormalUser> normalUsers = new List<NormalUser>
        {
            new NormalUser("abdo@gmail.com","abdo","123"),
        };

        public /// <summary>
    ///  An operation that does...
    /// 
    ///  @param firstParam a description of this parameter
    /// </summary>
    /// <param name="NormalUser">
    /// </param>
    /// <returns>
    /// </returns>
     void addUser(User user)
        {

            normalUsers.Add((NormalUser)user);
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
      UserController searchByEmail( string email)
    {
           foreach(User user in normalUsers)
            {
                
                if (user.getEmail().Equals(email))
                    return new NormalUserController((NormalUser)user);
            }
            return null;
    // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AED begin
    // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AED end

    }

      

        public /// <summary>
    ///  An operation that does...
    /// 
    ///  @param firstParam a description of this parameter
    /// </summary>
    /// <param name="NormalUser">
    /// </param>
    /// <returns>
    /// </returns>
     void updateUser(User user)
    {
    // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AF0 begin
    // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AF0 end

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
      void deleteUserByEmail( string a)
    {
        
    // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AF3 begin
    // section -87--2-87--42--46e34135:1711ce644e4:-8000:0000000000000AF3 end

    }
        public List<User> listUsers()
        {
            return new List<User>(normalUsers);
        }

    } /* end class NormalUserDataBase */

}
