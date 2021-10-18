using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStor.Data;
using WebStor.Domain;
using WebStor.Domain.Entities;
using WebStor.Services.Interfaces;

namespace WebStor.Services.InMemory
{
    public class InMemoryProductData : IProductData
    {
        IEnumerable<Section> IProductData.GetSections() => TestData.Sections;

        public Section GetSectionById(int Id) => TestData.Sections.FirstOrDefault(s => s.Id == Id);

        IEnumerable<Brand> IProductData.GetBrands() => TestData.Brands;

        public Brand GetBrandById(int Id) => TestData.Brands.FirstOrDefault(b => b.Id == Id);


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

        public Product GetProductById(int Id) => TestData.Products.FirstOrDefault(p => p.Id == Id);

    }
}
