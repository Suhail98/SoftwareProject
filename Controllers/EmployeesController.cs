/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{

    public static class Global
    {
        /// <summary>
        /// Global variable storing important stuff.
        /// </summary>
        static string username =null;
        static string password = null;

        /// <summary>
        /// Get or set the static important data.
        /// </summary>
        public static string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public static string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
    public class EmployeesController : ApiController
    {
        static List<AdminUser> emp = new List<AdminUser>
        {
            new AdminUser{ Email ="AbdoAyman@gmail.com",UserName="abdo",Password="123"},

        };
        static List<NormalUser> Normaluser = new List<NormalUser>
        {
            new NormalUser{ Email ="suhail@gmail.com",UserName="suhail",Password="456"},

        };
        public string CheckInfo(string username, string password)
        {
            foreach (AdminUser search in emp)
            {
                if ((search.GetName().Equals(username)) && (search.GetPassword().Equals(password)))
                {
                    Global.Username = username;
                    Global.Password = password;
                    return "Admin";
                }
            }
            foreach (NormalUser search in Normaluser)
            {
                if ((search.GetName().Equals(username)) && (search.GetPassword().Equals(password)))
                {
                    Global.Username = username;
                    Global.Password = password;
                    return "User";
                }
            }
            return "Error";
            
        }
        
        [HttpGet]
        public List<AdminUser> GetAll()
        {
            
            if (CheckInfo( Global.Username, Global.Password).Equals("Admin"))
                return emp;
            else
                return null;
        }

        [HttpGet]
        public string Login(string username, string password)
        {
            if (CheckInfo(username, password).Equals("Admin"))
                return "Login in By Admin " + Global.Username;
            else if(CheckInfo(username, password).Equals("User"))
                return "Login in By User " + username; 

            return "Canot Login, Please Try Again";
        }
        [HttpGet]
        public string Logut(string username)
        {
            Global.Username = null;
            Global.Password = null;
            return "Logout From UserName " + username;
        }


        //  return emp.FirstOrDefault(c =>c.Id == id);

        *//*      public employee GetEmployeeByName(string name)
              {

                  return emp.FirstOrDefault(c => c.Name == name);
              }*/
        /*      public void Delete(int id)
              {
                  emp.RemoveAll(c => c.Id == id);

              }*//*
        [HttpPut]
        public HttpResponseMessage AddAdmin(AdminUser p)
        {
            if (CheckInfo(Global.Username, Global.Password).Equals("Admin"))
            {
                emp.Add(p);
                return new HttpResponseMessage(HttpStatusCode.Created);

            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
    }
}
*/