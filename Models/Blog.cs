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
        [StringLength(50)]
        public string title { get; set; }

        [Required]
        [StringLength(500)]
        public string contents { get; set; }

        public DateTime create_at { get; set; }

        [Required]
        [StringLength(50)]
        public string create_by { get; set; }

        public int status { get; set; }
    }
}
