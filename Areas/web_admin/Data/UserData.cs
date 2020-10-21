using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Areas.web_admin.Data
{
    public class UserData
    {
        DataBaseBlog db = new DataBaseBlog();

        public User find(string id)
        {
            
            return db.Users.Find(id);
        }
        public List<User> all()
        {
            try
            {
                return db.Users.ToList();
            }
            catch(Exception ex)
            {
                return new List<User>();
            }
            
        }
        public String Insert(Models.User u)
        {
            db.Users.Add(u); 
            db.SaveChanges();
            return u.ID;
        }
        public User GetByUserName( string username)
        {
            return db.Users.SingleOrDefault(u => u.username == username);
        }
        public bool login(String user , String pass)
        {
            var result = db.Users.Count(u => u.username == user && u.password == pass);
            if (result > 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}