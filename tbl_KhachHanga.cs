//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KhoaLuanTotNghiep
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_KhachHanga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_KhachHanga()
        {
            this.tbl_DichVuVCNB = new HashSet<tbl_DichVuVCNB>();
            this.tbl_DMVanDon = new HashSet<tbl_DMVanDon>();
            this.tbl_HangHoa = new HashSet<tbl_HangHoa>();
            this.tbl_HopDong = new HashSet<tbl_HopDong>();
            this.tbl_KhoNoiBo = new HashSet<tbl_KhoNoiBo>();
            this.tbl_VanDon = new HashSet<tbl_VanDon>();
        }
    
        public long ID { get; set; }
        public Nullable<long> IDKH { get; set; }
        public string HoVaTen { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public string Email { get; set; }
        public string DonVi { get; set; }
        public string SoCMTND { get; set; }
        public Nullable<long> IDQuocTich { get; set; }
        public string NguyenQuan { get; set; }
        public byte[] Image { get; set; }
        public Nullable<long> IDHH { get; set; }
        public Nullable<long> IDHD { get; set; }
        public Nullable<long> IDTT { get; set; }
        public string SoTK { get; set; }
        public Nullable<long> IDDVVC { get; set; }
        public Nullable<long> IDDL { get; set; }
        public Nullable<long> IDDVKho { get; set; }
    
        public virtual tbl_DaiLi tbl_DaiLi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DichVuVCNB> tbl_DichVuVCNB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DMVanDon> tbl_DMVanDon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_HangHoa> tbl_HangHoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_HopDong> tbl_HopDong { get; set; }
        public virtual tbl_QuocTich tbl_QuocTich { get; set; }
        public virtual tbl_ThanhToan tbl_ThanhToan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_KhoNoiBo> tbl_KhoNoiBo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_VanDon> tbl_VanDon { get; set; }
    }
}
