namespace InvoiceMenagment.Api.Models
{
    public class ItemCategory : BasicEntity
    {
        public string? Name { get; set; }
        public string? ShortName { get; set; }

        public ICollection<ItemSubCategory> ItemSubCategories { get; set; }
    }
}
