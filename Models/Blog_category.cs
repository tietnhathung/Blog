namespace Blog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blog_category
    {
        [StringLength(50)]
        public string category_id { get; set; }

        [StringLength(50)]
        public string blog_id { get; set; }

        [StringLength(50)]
        public string ID { get; set; }

        public virtual Blog Blog { get; set; }

        public virtual Category Category { get; set; }
    }
}
