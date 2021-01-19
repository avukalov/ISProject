using AutoMapper;
using ISProject.DAL.Entities;
using ISProject.Model.Request;
using ISProject.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISProject.Common.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserRequest, UserEntity>();
            CreateMap<UserEntity, UserResponse>();
        }
    }
}
