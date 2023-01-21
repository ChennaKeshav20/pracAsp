using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pracAsp.Models;

namespace pracAsp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context = null;
        public ProductsController() 
        {
            _context = new ApplicationDbContext();
        }
        // GET: Products
        public ActionResult Index()
        {
           // Product product = new Product();
           // List<Product> products = product.GetProducts();
            var products = _context.Products.ToList();
            return View(products);
            
            
        }
        public ActionResult Details(int id) 
        {
           // Product productObj = new Product();
           // var product = productObj.GetProducts().FirstOrDefault();
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                return View(product);
            }
            return HttpNotFound();


        }   
        public ActionResult  Create() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
               return RedirectToAction("Index");
            }
            return View();
        }
    }
}