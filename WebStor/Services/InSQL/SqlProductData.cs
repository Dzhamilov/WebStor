using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStor.Domain;
using WebStor.Domain.Entities;
using WebStor.Services.Interfaces;
using WebStore.DAL.Context;

namespace WebStor.Services.InSQL
{
    public class SqlProductData : IProductData
    {
        private readonly WebStoreDB _db;

        public SqlProductData(WebStoreDB db) => _db = db;

        public IEnumerable<Section> GetSections() => _db.Sections;

        public Section GetSectionById(int Id) => _db.Sections.SingleOrDefault(s => s.Id == Id);


        public IEnumerable<Brand> GetBrands() => _db.Brands;

        public Brand GetBrandById(int Id) => _db.Brands.Find(Id);


        public IEnumerable<Product> GetProducts(ProductFilter Filter = null)
        {
            IQueryable<Product> query = _db.Products
               .Include(p => p.Brand)
               .Include(p => p.Section);

            if (Filter?.Ids?.Length > 0)
                query = query.Where(product => Filter.Ids.Contains(product.Id));
            else
            {
                if (Filter?.SectionId is { } section_id)
                    query = query.Where(p => p.SectionId == section_id);

                if (Filter?.BrandId is { } brand_id)
                    query = query.Where(p => p.BrandId == brand_id);
            }

            return query;
        }

        public Product GetProductById(int Id) => _db.Products
           .Include(p => p.Brand)
           .Include(p => p.Section)
           .FirstOrDefault(p => p.Id == Id);

    }
}
