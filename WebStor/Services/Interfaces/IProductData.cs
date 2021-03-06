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

        Section GetSectionById(int Id);

        IEnumerable<Brand> GetBrands();

        Brand GetBrandById(int Id);

        IEnumerable<Product> GetProducts(ProductFilter Filter = null);

        Product GetProductById(int Id);
    }
}
