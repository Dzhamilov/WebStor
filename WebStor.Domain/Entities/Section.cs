using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebStor.Domain.Entities.Base;
using WebStor.Domain.Entities.Base.Interfaces;

namespace WebStor.Domain.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    public class Section : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int? ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public Section Parent { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
