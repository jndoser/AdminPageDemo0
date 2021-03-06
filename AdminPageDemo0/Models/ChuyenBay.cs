namespace AdminPageDemo0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuyenBay")]
    public partial class ChuyenBay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuyenBay()
        {
            Ves = new HashSet<Ve>();
        }

        [Key]
        public long MaChuyenBay { get; set; }

        [StringLength(10)]
        public string DiemDi { get; set; }

        [StringLength(10)]
        public string DiemDen { get; set; }

        public DateTime? ThoiGianDi { get; set; }

        public DateTime? ThoiGianDen { get; set; }

        [StringLength(10)]
        public string MaMayBay { get; set; }

        public double? Gia { get; set; }

        public virtual MayBay MayBay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
