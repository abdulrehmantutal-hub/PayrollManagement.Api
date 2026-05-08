using InvoiceMenagment.Api.Models;

//public class Book : BasicEntity
//{      
//    public string AutoNumber { get; set; }
//    public int AccountDetailId { get; set; }
//    public AccountDetail AccountDetail { get; set; }
//    public string? Date { get; set; }
//    public ICollection<BookParameter> bookParameters { get; set; }

//}


public class Book : BasicEntity
{
    public string AutoNumber { get; set; }
    public int AccountDetailId { get; set; }                
    public AccountDetail AccountDetail { get; set; }       
    public string? Date { get; set; }
    public ICollection<BookParameter> bookParameters { get; set; }
}




