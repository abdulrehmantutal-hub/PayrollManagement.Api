namespace InvoiceMenagment.Api.Models.Interfaces
{
    public interface IBase<TKey>
    {
        TKey Id { get; set; }
    }
}
