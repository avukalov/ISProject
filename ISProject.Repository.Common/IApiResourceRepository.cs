using IdentityServer4.EntityFramework.Entities;

namespace ISProject.Repository.Common
{
    public interface IApiResourceRepository
    {
        void AddApiResource(ApiResource obj);
        void RemoveApiResource(ApiResource obj);
        void UpdateApiResource(ApiResource obj);
    }
}
