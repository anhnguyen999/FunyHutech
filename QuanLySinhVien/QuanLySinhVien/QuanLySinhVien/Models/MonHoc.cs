namespace QuanLySinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonHoc")]
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            DangKyMonHocs = new HashSet<DangKyMonHoc>();
        }

        [Key]
        public int MaMH { get; set; }

        [StringLength(50)]
        public string TenMH { get; set; }

        public int? MaChuyenNganh { get; set; }

        public virtual ChuyenNganh ChuyenNganh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyMonHoc> DangKyMonHocs { get; set; }
    }
}
