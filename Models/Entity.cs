using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using InvoiceMenagment.Api.Models.Interfaces;

namespace InvoiceMenagment.Api.Models
{
    public abstract class Entity<TKey> : IBase<TKey>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TKey Id { get; set; }

        [Required]
        public Guid GlobalId { get; set; } 
    }
}
