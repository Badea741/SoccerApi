using CommonGenericClasses;
using Microsoft.EntityFrameworkCore;
using Soccer.Shared.Entities;

namespace Soccer.Shared.Repositories;

public class TeamRepository : BaseRepo<Team>, ITeamRepository
{
    public TeamRepository(DbContext db) : base(db)
    {
    }
}