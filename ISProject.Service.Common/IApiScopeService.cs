using IdentityServer4.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ISProject.Service.Common
{
    public interface IApiScopeService
    {
        Task<int> AddApiScopeAsync(ApiScope model);
        Task<List<ApiScope>> GetAllAsync();
        Task<ApiScope> GetApiScopeByIdAsync(int id);
        Task<int> RemoveApiScopeAsync(ApiScope model);
        Task<int> UpdateApiScopeAsync(ApiScope model);
    }
}
