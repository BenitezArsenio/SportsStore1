using DomainModel.Abstract;
using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel.Concrete
{
    public class FakeProductsRepository : IProductsRepository
    {
        private static IQueryable<Product> fakeProducts = new List<Product>
        {
            new Product { Name = "Football", Price = 25},
            new Product { Name = "Surf Board", Price = 179},
            new Product { Name = "Boxing Gloves", Price = 35}
        }.AsQueryable();
        public IQueryable<Product> Products
        {
            get { return fakeProducts;  }
        }

    }
}
