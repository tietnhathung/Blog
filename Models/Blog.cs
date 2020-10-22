namespace Blog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blog
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [Display(Name = "Tiêu đề")]
        [StringLength(50)]
        public string title { get; set; }

        [Required]
        [Display(Name = "Nội dung")]
        [StringLength(500)]
        public string contents { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime create_at { get; set; }

        [Required]
        [Display(Name = "Tạo bởi")]
        [StringLength(50)]
        public string create_by { get; set; }

        [StringLength(255)]
        [Display(Name = "Ảnh dại diện")]

        public string thumbnail { get; set; }
        public int status { get; set; }

        public string Category { get; set; } 
        public IList<BLogCategory> BLogCategory {get;set;}
    }
}
