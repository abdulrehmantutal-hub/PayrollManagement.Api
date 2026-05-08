using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMenagment.Api.Models
{
    public class AccountSubGroup : BasicEntity
    {

        public int? AccountGroupId { get; set; }
        public AccountGroup AccountGroup { get; set; }
        public string? AutoNumber { get; set; }

        [StringLength(200)]
        public string? Name { get; set; }

        // Navigation property for related AccountDetails
        public ICollection<AccountDetail> AccountDetails { get; set; }
    }
}
