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
    
    public partial class Sanpham
    {
        public Sanpham()
        {
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            this.MauSacs = new HashSet<MauSac>();
        }
    
        public int SanphamID { get; set; }
        public string TenSanpham { get; set; }
        public string MoTa { get; set; }
        public decimal Gia { get; set; }
        public Nullable<byte> TrangThai { get; set; }
        public string AnhDaiDien { get; set; }
        public Nullable<byte> NoiBat { get; set; }
        public Nullable<int> PhanLoaiSanPhamID { get; set; }
    
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual PhanLoaiSanPham PhanLoaiSanPham { get; set; }
        public virtual ICollection<MauSac> MauSacs { get; set; }
    }
}
