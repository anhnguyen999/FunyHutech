namespace QuanLySinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangKyMonHoc")]
    public partial class DangKyMonHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDK { get; set; }

        public int? MaMH { get; set; }

        [StringLength(10)]
        public string MaSV { get; set; }

        public DateTime? ThoiGianDK { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
