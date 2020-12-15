using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModel.Abstract;
using DomainModel.Concrete;

namespace WebUI.Controllers
{
    public class ProductsController : Controller
    {
        private IProductsRepository productsRepository;
        public ProductsController()
        {
            //temporary 
            productsRepository = new FakeProductsRepository();
        }

        // GET: Products
        public ViewResult List()
        {
            return View(productsRepository.Products.ToList());
        }
        
    }
}