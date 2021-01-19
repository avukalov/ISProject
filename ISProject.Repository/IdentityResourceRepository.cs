using IdentityServer4.EntityFramework.Entities;
using ISProject.DAL;
using ISProject.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISProject.Repository
{
    public class IdentityResourceRepository : Repository<IdentityResource>, IIdentityResourceRepository
    {
        public IdentityResourceRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void AddIdentityResource(IdentityResource obj) => Add(obj);
        public void RemoveIdentityResource(IdentityResource obj) => Remove(obj);
        public void UpdateIdentityResource(IdentityResource obj) => Update(obj);

    }
}
