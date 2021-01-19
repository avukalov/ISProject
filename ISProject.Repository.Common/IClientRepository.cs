using IdentityServer4.EntityFramework.Entities;

namespace ISProject.Repository.Common
{
    public interface IClientRepository
    {
        void AddClient(Client obj);
        void RemoveClient(Client obj);
        void UpdateClient(Client obj);
    }
}
