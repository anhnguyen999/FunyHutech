//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL_QuanLySinhVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            this.DangKyMonHocs = new HashSet<DangKyMonHoc>();
        }
    
        public int MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public Nullable<int> MaChuyenNganh { get; set; }
    
        public virtual ChuyenNganh ChuyenNganh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyMonHoc> DangKyMonHocs { get; set; }
    }
}
