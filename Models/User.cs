namespace Blog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [StringLength(50)]
        [DisplayName("Họ và tên")]
        public string full_name { get; set; }

        [StringLength(10)]
        [DisplayName("Tài khoản")]
        public string username { get; set; }

        [StringLength(10)]
        [DisplayName("Mật khẩu")]
        public string password { get; set; }

        [DisplayName("Thời gian tạo")]
        public DateTime? create_at { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
