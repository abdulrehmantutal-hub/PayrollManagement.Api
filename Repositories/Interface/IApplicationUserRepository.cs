

using InvoiceMenagment.Api.Models;
using InvoiceMenagment.Api.Repositories.Interfaces;

namespace InvoiceMenagment.Api.Repository
{
    public interface IApplicationUserRepository : IGenericRepository<ApplicationUser>
    {
        Task<ApplicationUser> GetByUsernameAsync(string emailAddress);
        Task<IList<ApplicationUser>> GetListByRoleIdAsync(int roleId);


        //Task<PageResult<ApplicationUser>> GetFilteredUsersAsync(UserFilterDto filterDto);

    }
}
