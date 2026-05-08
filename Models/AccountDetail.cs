using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceMenagment.Api.Models
{
    public class AccountDetail : BasicEntity
    {

       public int? AccountSubGroupId { get; set; } 

        public AccountSubGroup AccountSubGroup { get; set; } 

        public string AutoNumber { get; set; }  

        public string? Name { get; set; }
        public string? ShortName { get; set; }

        public string? OpeningDebitAmount { get; set; }
        public string? OpeningCreditAmount { get; set; }
        public string? CreditLimit { get; set; }

        public string? Address { get; set; }
        public int? SectorId { get; set; }
        public LookUpName Sector { get; set; }
        public int? CityId { get; set; }
        public City? city { get; set; }
        public bool? IsCustomer { get; set; }
        public bool? IsSupplier { get; set; }






        public ICollection<AccountDetailTypeParameter> accountDetailTypeParameters { get; set; }

    }
}
