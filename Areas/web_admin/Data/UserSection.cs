using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Areas.web_admin.Data
{
    [Serializable]
    public class UserSection
    {
        public string UserID { set; get; }
        public string UserName { set; get; }
        public string FullName { set; get; }

        public UserSection() {}
        public UserSection( User u )
        {
            this.UserID = u.ID;
            this.UserName = u.username;
            this.FullName = u.full_name;
        }
    }
}