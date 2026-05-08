namespace InvoiceMenagment.Api.Models
{
    public class Role : BasicEntity
    {
        public string? Name { get; set; }

        public ICollection<RolePagePermission> RolePagePermissions { get; set; }
    }
}
