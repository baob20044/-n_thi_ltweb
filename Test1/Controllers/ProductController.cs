using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class ProductController : Controller
    {
        ShopContext _context = new ShopContext();
        // GET: Product
        public class ProductViewModel
        {
            public List<PhanLoaiSanPham> phanLoaiSanPham { get; set; }
            public Sanpham sanpham { get; set; }
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateProduct()
        {
            var categories = _context.phanLoaiSanPhams.ToList();
            ProductViewModel productViewModel = new ProductViewModel()
            {
                phanLoaiSanPham = categories,
            };
            return View(productViewModel);
        }
        [HttpPost]
        public ActionResult CreateProduct(ProductViewModel model, HttpPostedFileBase AnhDaiDienFile)
        {
            // List of categories (assuming this is part of your model)
            var categories = _context.phanLoaiSanPhams.ToList();
            model.phanLoaiSanPham = categories;
            // Handle the file upload and store the file name in the model
            if (AnhDaiDienFile != null)
            {
                model.sanpham.AnhDaiDien = AnhDaiDienFile.FileName;
            }

            // Regular expression to validate the Gia field (price) - only allows numbers and up to 2 decimal places
            string pattern = @"^\d+(\.\d{1,2})?$";

            // Validate the Gia field with the regular expression
            if (model.sanpham.Gia == null || !Regex.IsMatch(model.sanpham.Gia.ToString(), pattern))
            {
                ModelState.AddModelError("sanpham.Gia", "Please enter a valid price (e.g., 100 or 100.99).");
            }

            // Validate the file upload for AnhDaiDien - only allows .jpg files
            if (AnhDaiDienFile != null)
            {
                string fileExtension = Path.GetExtension(AnhDaiDienFile.FileName).ToLower();
                string pattern2 = @"\.jpg$";  // Only allow .jpg extension

                if (!Regex.IsMatch(fileExtension, pattern2))
                {
                    ModelState.AddModelError("sanpham.AnhDaiDien", "Only .jpg files are allowed.");
                }
            }
            else
            {
                ModelState.AddModelError("sanpham.AnhDaiDien", "Please upload an image.");
            }

            // If the model is invalid, return the view with the current model
            if (!ModelState.IsValid)
            {
                return View(model);  // Return the full model (ProductViewModel) with the validation error
            }

            // Save the product to the database
            _context.sanPham.Add(model.sanpham);  // Assuming _context is your database context
            _context.SaveChanges();

            return RedirectToAction("Index");  // Redirect to Index page after saving
        }


    }
}