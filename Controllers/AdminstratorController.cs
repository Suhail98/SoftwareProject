// FILE: D:/New Folder (22)/UserPackage/AdminstratorController.cs

// In this section you can add your own using directives
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000963 begin
// section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000963 end
namespace UserPackage
{

    /// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
    /// </summary>
    public class AdminstratorController : UserController
    {
        // Attributes

        private Adminstrator admin;


        public AdminstratorController(Adminstrator admin)
        {
            this.admin = admin;
        }

        public AdminstratorController(string nemail, string userName, string password)
        {
            admin = new Adminstrator(nemail, userName, password);
        }

        public override string getPassword()
        {
            return admin.getPassword();
        }
        public override User getModel()
        {
            return admin;
        }
        public override string getEmail()
        {
            return admin.getEmail();
        }
        public override string getUserName()
        {
            return admin.getUserName();
        }
    } /* end class AdminstratorController */

}
