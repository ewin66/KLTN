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
    
    public partial class tbl_ContainerXNkhau
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ContainerXNkhau()
        {
            this.tbl_HangHoa = new HashSet<tbl_HangHoa>();
        }
    
        public long ID { get; set; }
        public Nullable<long> IDContainerXNKhau { get; set; }
        public string DiemBD { get; set; }
        public Nullable<System.DateTime> NgayBD { get; set; }
        public string DiemDen { get; set; }
        public Nullable<System.DateTime> NgayDen { get; set; }
        public Nullable<double> GiaThanh { get; set; }
        public Nullable<int> SoNgay { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_HangHoa> tbl_HangHoa { get; set; }
    }
}