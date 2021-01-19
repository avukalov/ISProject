using Microsoft.AspNetCore.Identity;
using System;

namespace ISProject.DAL.Entities
{
    public class UserEntity : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }
    }
}