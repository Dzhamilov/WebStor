using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStor.Domain.Entities.Base;
using WebStor.Domain.Entities.Base.Interfaces;

namespace WebStor.Domain.Entities
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        //[Column("BrandOrder")]
        public int Order { get; set; }
    }
}
