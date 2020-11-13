namespace ServiceAvtoProkat
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Zakaz = new HashSet<Zakaz>();
        }

        [Key]
        public int EmplID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string EmplName { get; set; }

        public int PostID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string EmplTel { get; set; }

        public virtual Post Post { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zakaz> Zakaz { get; set; }
    }
}
