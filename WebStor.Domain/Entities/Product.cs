using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStor.Domain.Entities.Base;
using WebStor.Domain.Entities.Base.Interfaces;

namespace WebStor.Domain.Entities
{
    public class Product : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int SectionId { get; set; }

        public Section Section { get; set; }

        public int? BrandId { get; set; }

        public Brand Brand { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}
