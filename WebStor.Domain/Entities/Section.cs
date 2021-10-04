using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebStor.Domain.Entities.Base;
using WebStor.Domain.Entities.Base.Interfaces;

namespace WebStor.Domain.Entities
{
    public class Section : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int? ParentId { get; set; }
    }
}
