using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel.Abstract
{
    interface IProductsRepository
    {
        IQueryable<Product> Products { get; }
    }
}
