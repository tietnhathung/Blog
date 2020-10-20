namespace Blog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [StringLength(50)]
        [Display(Name = "Họ và tên")]

        public string full_name { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Tên đăng nhập")]
        public string username { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mật khẩu")]
        public string password { get; set; }

        [Display(Name = "Thời gian tạo")]
        public DateTime create_at { get; set; }

        [StringLength(50)]
        public string ID { get; set; }
    }
}
