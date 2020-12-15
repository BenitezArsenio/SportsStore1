using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DomainModel.Abstract;
using System.Linq;


namespace DomainModel.Concrete
{

    public class SqlProductsRepository 
    {
        public DbSet<Product> productsTable;

        public IQueryable<Product> Products
        {
            get { return productsTable; }
        }
    }
}
