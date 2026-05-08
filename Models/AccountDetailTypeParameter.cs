namespace InvoiceMenagment.Api.Models
{
    public class AccountDetailTypeParameter : BasicEntity
    {
        public int AccountDetailId { get; set; }
        public AccountDetail AccountDetail { get; set; }
        public int? LookUpNameId { get; set; }

        public LookUpName? lookUpName { get; set; }
    }
}
