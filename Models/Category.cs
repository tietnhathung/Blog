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
        public string name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public DateTime create_at { get; set; }

        [Required]
        [StringLength(50)]
        public string create_by { get; set; }
    }
}
