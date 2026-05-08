namespace InvoiceMenagment.Api.DTOs.Response
{
    public class GetRolePermissions
    {
        public int? Id { get; set; } // Changed to nullable
        public int? RoleId { get; set; } // Changed to nullable
        public int? PageId { get; set; } // Changed to nullable
        public int? ParentId { get; set; } // Changed to nullable
        public bool IsView { get; set; }
        public bool IsAdd { get; set; }
        public bool IsEdit { get; set; }
        public bool IsDeleted { get; set; }
        public string GlobalId { get; set; }

        public List<RolePagePermissions> RolePagePermissions { get; set; }
    }

    public class RolePagePermissions
    {
        public int? Id { get; set; } // Changed to nullable
        public int? RoleId { get; set; } // Changed to nullable
        public int? PageId { get; set; } // Changed to nullable
        public int? ParentId { get; set; } // Changed to nullable
        public bool? IsView { get; set; }
        public bool? IsAdd { get; set; }
        public bool? IsEdit { get; set; }
        public bool? IsDeleted { get; set; }
        public string? GlobalId { get; set; }

        public List<RoleControlPermissions> RoleControlPermissions { get; set; }
        public List<Pages> Pages { get; set; }
    }

    public class RoleControlPermissions
    {
        public int? Id { get; set; } // Changed to nullable
        public int? RolePagePermissionId { get; set; } // Changed to nullable
        public int? PageId { get; set; } // Changed to nullable
        public int? ControlId { get; set; } // Changed to nullable
        public bool? IsView { get; set; }
        public int? RoleId { get; set; } // Changed to nullable
    }

    public class Pages
    {
        public int? Id { get; set; } // Changed to nullable
        public int? ParentId { get; set; } // Changed to nullable
        public bool? IsCollapsed { get; set; }
        public string? Title { get; set; }
        public string? GlobalId { get; set; }
    }
}
