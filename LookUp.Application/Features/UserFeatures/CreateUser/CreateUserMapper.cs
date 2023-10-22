using AutoMapper;
using LookUp.Domain.Entities;

namespace LookUp.Application.Features.UserFeatures.CreateUser;

public sealed class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateUserRequest, User>();
        CreateMap<User, CreateUserResponse>();
    }
}