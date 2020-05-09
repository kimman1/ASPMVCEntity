using NW.Models;
using NW.Views.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace NW.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext db ;
        // GET: Product
        public ProductController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var p = db.Products.Select(s => s);
            return View(p);
        }
        public ActionResult List()
        {
            List<Product> sp = db.Products.Select(s => s).ToList();
            List<ProductViewModel> p = sp.Select(s => new ProductViewModel
            {
                Name = s.Name,
                Id = s.Id,
                Price = s.Price,
                Producer = s.Producer,
                Creator = s.Creator,
                Description = s.Description,
                CategoryId = s.CategoryId,
                CategoryName = s.Category.Name,
            }).ToList() ;
           
            return View(p);
        }
    }
}