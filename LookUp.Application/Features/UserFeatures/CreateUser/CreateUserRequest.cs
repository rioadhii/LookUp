using MediatR;

namespace LookUp.Application.Features.UserFeatures.CreateUser;

public sealed record CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>;