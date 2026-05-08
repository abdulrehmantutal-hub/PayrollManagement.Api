namespace InvoiceMenagment.Api.DTOs.Request
{
    public class PageModuleRequest
    {
        public int? ParentId { get; set; }
        public bool? IsCollapsed { get; set; }
        public int RoleId { get; set; }      
        public List<int?> PageIds { get; set; }
        public string? Title { get; set; }
        public string? Path { get; set; }
        public string? Type { get; set; }
        public string? Icon { get; set; }
        public bool? IsHidden { get; set; }
        public string? Translate { get; set; }
        public string? Classes { get; set; }
        public string? GroupClasses { get; set; }
        public bool? IsExactMatch { get; set; }
        public bool? IsTarget { get; set; }
        public bool? IsBreadCrumb { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }
    }
}
