using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMenagment.Api.Models
{
    public class AccountGroup : BasicEntity
    {

        public string? AutoNumber { get; set; }  
        public string Name { get; set; }

        // Navigation property for related AccountSubGroups
        public ICollection<AccountSubGroup> AccountSubGroups { get; set; }
    }
}
