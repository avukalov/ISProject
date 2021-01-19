using IdentityServer4.Models;
using System.Threading.Tasks;

namespace ISProject.Service.Common
{
    public interface IApiResourceService
    {
        Task<int> AddApiResourceAsync(ApiResource model);
        Task<int> RemoveApiResourceAsync(ApiResource model);
        Task<int> UpdateApiResourceAsync(ApiResource model);
    }
}
