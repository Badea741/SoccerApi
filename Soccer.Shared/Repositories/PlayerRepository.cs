using CommonGenericClasses;
using Microsoft.EntityFrameworkCore;
using Soccer.Shared.Entities;
namespace Soccer.Shared.Repositories;
public class PlayerRepository : BaseRepo<Player>, IPlayerRepository
{
    public PlayerRepository(DbContext db) : base(db)
    {
    }
}