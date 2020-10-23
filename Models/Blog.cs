namespace Blog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Blog()
        {
            Blog_category = new HashSet<Blog_category>();
        }

        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Tiêu đề")]
        public string title { get; set; }

        [Required]
        [DisplayName("Nội dung")]
        public string contents { get; set; }

        public DateTime create_at { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Ngày tạo")]
        public string create_by { get; set; }

        public int status { get; set; }

        [StringLength(255)]
        [DisplayName("Ảnh đại diện")]
        public string thumbnail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Blog_category> Blog_category { get; set; }
    }
}
