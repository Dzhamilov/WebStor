using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStor.Domain;
using WebStor.Domain.Entities;

namespace WebStor.Services.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Section> GetSections();

        IEnumerable<Brand> GetBrands();

        IEnumerable<Product> GetProducts(ProductFilter Filter = null);
    }
}
