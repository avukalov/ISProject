using IdentityServer4.Models;
using System.Threading.Tasks;

namespace ISProject.Service.Common
{
    public interface IIdentityResourceService
    {
        Task<int> AddIdentityResourceAsync(IdentityResource model);
        Task<int> RemoveIdentityResourceAsync(IdentityResource model);
        Task<int> UpdateIdentityResourceAsync(IdentityResource model);
    }
}
