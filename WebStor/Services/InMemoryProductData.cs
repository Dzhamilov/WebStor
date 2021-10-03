using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStor.Data;
using WebStor.Domain.Entities;
using WebStor.Services.Interfaces;

namespace WebStor.Services
{
    public class InMemoryProductData : IProductData
    {
        IEnumerable<Section> IProductData.GetSections() => TestData.Sections;

        IEnumerable<Brand> IProductData.GetBrands() => TestData.Brands;
    }
}
