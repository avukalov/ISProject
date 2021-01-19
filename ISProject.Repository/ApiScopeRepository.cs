using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.EntityFramework.Mappers;
using ISProject.DAL;
using ISProject.Repository.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApiScope = IdentityServer4.Models.ApiScope;

namespace ISProject.Repository
{
    public class ApiScopeRepository : Repository<IdentityServer4.EntityFramework.Entities.ApiScope>, IApiScopeRepository
    {
        private readonly ApplicationDbContext _context;

        public ApiScopeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        private ApiScope ToModel(IdentityServer4.EntityFramework.Entities.ApiScope arg)
        {
            return arg.ToModel();
        }

        public void AddApiScope(ApiScope obj) => Add(obj.ToEntity());

        public async Task<List<ApiScope>> GetAllAsync()
        {
            var apiScopesList = await GetAll()
                .Include(a => a.UserClaims)
                .ToListAsync();
            return apiScopesList.Select(ToModel).ToList();
        }

        public async Task<ApiScope> GetByIdAsync(int id)
        {
            var apiScope = await Find(a => a.Id == id).FirstOrDefaultAsync();
            return apiScope.ToModel();
        }

        public void RemoveApiScope(ApiScope obj) => Remove(obj.ToEntity());
        public void UpdateApiScope(ApiScope obj) => Update(obj.ToEntity());

        
    }
}
