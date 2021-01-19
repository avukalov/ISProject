using IdentityServer4.EntityFramework.Mappers;
using IdentityServer4.Models;
using ISProject.Repository.Common;
using ISProject.Service.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISProject.Service
{
    public class ApiScopeService : IApiScopeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IApiScopeRepository _apiScopeRepository;

        public ApiScopeService(IUnitOfWork unitOfWork, IApiScopeRepository apiScopeRepository)
        {
            _unitOfWork = unitOfWork;
            _apiScopeRepository = apiScopeRepository;
        }

        public async Task<int> AddApiScopeAsync(ApiScope model)
        {
            _apiScopeRepository.AddApiScope(model);
            return await _unitOfWork.SaveChangesAsync();

        }

        public async Task<List<ApiScope>> GetAllAsync()
        {
            return await _apiScopeRepository.GetAllAsync();
        }

        public async Task<ApiScope> GetApiScopeByIdAsync(int id)
        {
            return await _apiScopeRepository.GetByIdAsync(id);
        }

        public Task<int> RemoveApiScopeAsync(ApiScope model)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateApiScopeAsync(ApiScope model)
        {
            throw new NotImplementedException();
        }
    }
}
