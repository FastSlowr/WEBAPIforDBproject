namespace ServiceAvtoProkat
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Zakaz = new HashSet<Zakaz>();
        }

        public int ClientID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ClientName { get; set; }

        public DateTime ClientDate { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ClientPassport { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ClientNumDrive { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ClientTel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zakaz> Zakaz { get; set; }
    }
}
