using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStor.Data;
using WebStor.Domain;
using WebStor.Domain.Entities;
using WebStor.Services.Interfaces;

namespace WebStor.Services
{
    public class InMemoryProductData : IProductData
    {
        IEnumerable<Section> IProductData.GetSections() => TestData.Sections;

        IEnumerable<Brand> IProductData.GetBrands() => TestData.Brands;

        public IEnumerable<Product> GetProducts(ProductFilter Filter = null)
        {
            IEnumerable<Product> query = TestData.Products;

            //if (Filter?.SectionId != null)
            //    query = query.Where(p => p.SectionId == Filter.SectionId);

            if (Filter?.SectionId is { } section_id)
                query = query.Where(p => p.SectionId == section_id);

            if (Filter?.BrandId is { } brand_id)
                query = query.Where(p => p.BrandId == brand_id);

            return query;
        }
    }
}
