using AutoMapper;
using InvoiceMenagment.Api.DTOs;
using InvoiceMenagment.Api.DTOs.Request;
using InvoiceMenagment.Api.DTOs.Requests;
using InvoiceMenagment.Api.DTOs.Response;
using InvoiceMenagment.Api.Models;

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

            CreateMap<PagesRequest, Page>();
            CreateMap<Page, PagesResponse>();

            //Mapping Page Control
            CreateMap<PageControlRequestDto, Control>();
            CreateMap<Control, PageControlResponse>();

            CreateMap<CreateDepartmentRequest, Department>();
            CreateMap<UpdateDepartmentRequest, Department>();
            CreateMap<Department, DepartmentResponse>();

            // Mapping Designation
            CreateMap<DesignationRequest, Designation>();
            CreateMap<Designation, DesignationResponse>()
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department != null ? src.Department.DepartmentName : null));
        }
    }
}