namespace ServiceAvtoProkat
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            Zakaz = new HashSet<Zakaz>();
        }

        public int CarID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Mark { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Model { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Colour { get; set; }

        public int CarMileage { get; set; }

        public int Year { get; set; }

        public int CarPriseDay { get; set; }

        public int Zalog { get; set; }

        public bool? CarAbroad { get; set; }

        public bool? Child { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Nomer { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string CarVinKuzov { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zakaz> Zakaz { get; set; }
    }
}
