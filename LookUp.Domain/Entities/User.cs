using LookUp.Domain.Common;

namespace LookUp.Domain.Entities;

public class User : BaseEntity
{
    public string Email { get; set; }
    public string Name { get; set; }
}