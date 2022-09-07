namespace Soccer.Shared.Repositories;
public class PlayerRepository : BaseRepo<Player>, IPlayerRepository
{
    public PlayerRepository(DbContext db) : base(db)
    {
    }
}