namespace ServiceAvtoProkat
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zakaz")]
    public partial class Zakaz
    {
        public int ZakazID { get; set; }

        public DateTime ZakazStart { get; set; }

        public DateTime ZakazEnd { get; set; }

        public bool? Check { get; set; }

        public int EmplID { get; set; }

        public int? AktVidachi { get; set; }

        public int? AktPriema { get; set; }

        public int ClientID { get; set; }

        public int CarID { get; set; }

        public virtual Car Car { get; set; }

        public virtual Client Client { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
