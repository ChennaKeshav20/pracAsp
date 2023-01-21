using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pracAsp.Models;

namespace pracAsp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context = null;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customers
        public ActionResult Index()
        {
            //Customer customer = new Customer();
            //List<Customer> customers = customer.GetCustomers();
            var Customer = _context.Customers.ToList();
            return View(Customer);
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.FirstOrDefault(p => p.Id == id);
            if (customer != null)
            {
                return View(customer);
            }
            return HttpNotFound();
        }
        public ActionResult Create()
        {
            
            return View();
        }
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}