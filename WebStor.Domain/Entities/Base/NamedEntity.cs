using System.ComponentModel.DataAnnotations;
using WebStor.Domain.Entities.Base.Interfaces;

namespace WebStor.Domain.Entities.Base
{
    public abstract class NamedEntity : Entity, INamedEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
