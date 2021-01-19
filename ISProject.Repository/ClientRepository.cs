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
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void AddClient(Client obj) => Add(obj);
        public void RemoveClient(Client obj) => Remove(obj);
        public void UpdateClient(Client obj) => Update(obj);

    }
}
