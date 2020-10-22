namespace Blog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tên")]
        public string name { get; set; }

        [StringLength(255)]
        [Display(Name = "Mô tả")]
        public string description { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime create_at { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Người tạo")]
        public string create_by { get; set; }
        
        public string Blog { get; set; }
        public IList<BLogCategory> BLogCategory {get;set;}
    }
}
