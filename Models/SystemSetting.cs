using System.ComponentModel.DataAnnotations;

namespace InvoiceMenagment.Api.Models
{
    public class SystemSetting : BasicEntity
    {
        [Key]
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string SmtpHost { get; set; }
        public string SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
        public bool SmtpEnableSsl { get; set; }
        public string MrnPrefix { get; set; }
    }
}
