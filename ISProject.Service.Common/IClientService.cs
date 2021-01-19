using IdentityServer4.Models;
using System.Threading.Tasks;

namespace ISProject.Service.Common
{
    public interface IClientService
    {
        Task<int> AddClientAsync(Client model);
        Task<int> RemoveClientAsync(Client model);
        Task<int> UpdateClientAsync(Client model);
    }
}
