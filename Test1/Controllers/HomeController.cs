using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class HomeController : Controller
    {
        ShopContext _context = new ShopContext();
        public class ProductViewModel
        {
            public List<PhanLoaiSanPham> phanLoaiSanPham { get; set; }
            public List<Sanpham> sanpham { get; set; }
        }
        public ActionResult Index()
        {
            var categories = _context.phanLoaiSanPhams.ToList();
            var products = _context.sanPham.ToList();

            ProductViewModel productViewModel = new ProductViewModel()
            {
                phanLoaiSanPham = categories,
                sanpham = products
            };
            return View(productViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}