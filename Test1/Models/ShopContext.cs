using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("QuanLyBanQuanAoEntities") // Name matches connection string
        {
        }
        public DbSet<PhanLoaiSanPham> phanLoaiSanPhams { get; set; }
        public DbSet<Sanpham> sanPham { get; set; }


    }
}