namespace Blog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Blog_category = new HashSet<Blog_category>();
        }

        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Tên")]
        public string name { get; set; }

        [StringLength(255)]
        [DisplayName("Mô tả")]
        public string description { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime create_at { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Blog_category> Blog_category { get; set; }
    }
}
