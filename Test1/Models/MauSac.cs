//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MauSac
    {
        public MauSac()
        {
            this.ChiTietSanPhamMuas = new HashSet<ChiTietSanPhamMua>();
            this.Sanphams = new HashSet<Sanpham>();
        }
    
        public int MauSacID { get; set; }
        public string TenMauSac { get; set; }
    
        public virtual ICollection<ChiTietSanPhamMua> ChiTietSanPhamMuas { get; set; }
        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}