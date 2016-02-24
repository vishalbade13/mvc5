using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEcomStore.Domain.Abstract;
using MyEcomStore.Domain.Entities;
using PagedList;

namespace MyEcomStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository productRepo;
        public ProductController(IProductRepository productRepo)
        {
            this.productRepo = productRepo;
        }

        public ActionResult List(int page = 1, int pageSize = 2)
        {
            PagedList<Product> model = new PagedList<Product>(productRepo.Products.OrderBy(x=> x.Category), page, pageSize);
            return View(model);
        }
    }
}