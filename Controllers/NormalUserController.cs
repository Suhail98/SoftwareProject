// FILE: D:/New Folder (22)/UserPackage/NormalUserController.cs

// In this section you can add your own using directives
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000964 begin
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000964 end
using System;

namespace UserPackage {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class NormalUserController : UserController
{
    // Attributes

    private NormalUser normalUser;
       

        public  NormalUserController(NormalUser normalUser)
        {
            this.normalUser = normalUser;
        }

        public NormalUserController(string email, string userName, string password)
        {
            normalUser = new NormalUser(email, userName, password);
        }

        public override string getPassword()
        {
            return normalUser.getPassword();
        }

        public NormalUser getNormalUser()
        {
            return normalUser;
        }
        public override User getModel()
        {
            return normalUser;
        }
        public override string getEmail()
        {
            return normalUser.getEmail();
        }
        public override string getUserName()
        {
            return normalUser.getUserName();
        }
    } /* end class NormalUserController */

}
