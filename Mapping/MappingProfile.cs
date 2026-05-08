using InvoiceMenagment.Api.DTOs;
using InvoiceMenagment.Api.DTOs.Request;
using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Models.InvoiceMenagment.Api.Models;
using AutoMapper;
namespace InvoiceMenagment.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUserRequestDto, ApplicationUser>();
            CreateMap<ApplicationUser, ApplicationUserResponse>();

            CreateMap<RoleRequest, Role>();
            CreateMap<Role, RoleResponse>();

            CreateMap<RolePagePermissionRequest, RolePagePermission>();
            CreateMap<RolePagePermission, RolePagePermissionResponse>();

            CreateMap<RoleControlPermissionRequest, RoleControlPermission>();
            CreateMap<RoleControlPermission, RoleControlPermissionResponse>();

            CreateMap<RolePagePermission, RolePagePermissionResponse>();
            CreateMap<RoleControlPermission, RoleControlPermissionResponse>();

        }
    }

}
