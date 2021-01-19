using IdentityServer4.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISProject.Repository.Common
{
    public interface IApiScopeRepository
    {
        Task<List<ApiScope>> GetAllAsync();
        Task<ApiScope> GetByIdAsync(int id);
        void AddApiScope(ApiScope obj);
        void RemoveApiScope(ApiScope obj);
        void UpdateApiScope(ApiScope obj);
    }
}
