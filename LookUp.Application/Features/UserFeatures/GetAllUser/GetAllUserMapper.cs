using AutoMapper;
using LookUp.Domain.Entities;

namespace LookUp.Application.Features.UserFeatures.GetAllUser;

public sealed class GetAllUserMapper : Profile
{
    public GetAllUserMapper()
    {
        CreateMap<User, GetAllUserResponse>();
        CreateMap<User, GetAllUserResponse>();
    }
}