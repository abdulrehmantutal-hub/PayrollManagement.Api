namespace InvoiceMenagment.Api.Models
{
    public class ItemSubCategory : BasicEntity
    {
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public int? ItemCategoryId { get; set; }
        public ItemCategory? ItemCategory { get; set; }       
        public ICollection<Item> Items { get; set; }
    }
}
