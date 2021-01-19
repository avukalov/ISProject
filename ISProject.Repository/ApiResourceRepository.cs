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
    public class ApiResourceRepository : Repository<ApiResource>, IApiResourceRepository
    {
        public ApiResourceRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void AddApiResource(ApiResource obj) => Add(obj);
        public void RemoveApiResource(ApiResource obj) => Remove(obj);
        public void UpdateApiResource(ApiResource obj) => Update(obj);

    }
}
