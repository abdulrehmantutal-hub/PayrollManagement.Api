namespace InvoiceMenagment.Api.Http
{
    public interface IPageRequest
    {
        int Page { get; set; }
        int PageSize { get; set; }
    }
}
