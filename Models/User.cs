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
        public string full_name { get; set; }

        [StringLength(10)]
        public string username { get; set; }

        [StringLength(10)]
        public string password { get; set; }

        public DateTime? create_at { get; set; }

        [StringLength(50)]
        public string ID { get; set; }
    }
}
