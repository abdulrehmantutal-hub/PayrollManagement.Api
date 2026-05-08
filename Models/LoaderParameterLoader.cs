namespace InvoiceMenagment.Api.Models
{
    public class LoaderParameterLoader : BasicEntity
    {
        public int LoaderParameterId { get; set; }
        public LoaderParameter LoaderParameter { get; set; }

        public int LoaderId { get; set; }
        public LookUpName Loader { get; set; }
    }
}
