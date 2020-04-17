// FILE: D:/New Folder (22)/UserPackage/User.cs

// In this section you can add your own using directives
    // section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000969 begin
    // section -87--2-87--42--4267bcd9:1710d3b46a2:-8000:0000000000000969 end
namespace UserPackage {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class User
{
    // Attributes

    public string email;

    public string userName;

    public string password;

    private bool isLogged = false;
    public User() { }
    public User(string email, string userName, string password)
        {
            this.email = email;
            this.userName = userName;
            this.password = password;
        }
    public string getPassword()
        {
            return password;
        }
     public string getUserName()
        {
            return userName;
        }
        public string getEmail()
        {
            return email;
        }
        public void setString(string email)
        {
            this.email = email;
        }
} /* end class User */

}
