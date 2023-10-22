using LookUp.Application.Repositories;
using LookUp.Domain.Entities;
using LookUp.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace LookUp.Persistence.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(DataContext context) : base(context)
    {
    }

    public Task<User> GetByEmail(string email, CancellationToken cancellationToken)
    {
        return Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
    }
}