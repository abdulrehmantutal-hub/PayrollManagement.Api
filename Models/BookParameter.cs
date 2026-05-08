using InvoiceMenagment.Api.Models;

public class BookParameter : BasicEntity
{      
    public int? BookId { get; set; }
    public Book book { get; set; }
    public int? BookAccountDetailId { get; set; }
    public AccountDetail BookAccountDetail { get; set; }
    public string? Date { get; set; }
    public int? PaymentTypeId { get; set; }
    public LookUpName PaymentType { get; set; }
    public string? ReceiptAmount { get; set; }
    public string? PaymentAmount { get; set; }
    public string? Remarks { get; set; }
}
