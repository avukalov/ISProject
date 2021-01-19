using IdentityServer4.EntityFramework.Entities;

namespace ISProject.Repository.Common
{
    public interface IIdentityResourceRepository
    {
        void AddIdentityResource(IdentityResource obj);
        void RemoveIdentityResource(IdentityResource obj);
        void UpdateIdentityResource(IdentityResource obj);
    }
}
