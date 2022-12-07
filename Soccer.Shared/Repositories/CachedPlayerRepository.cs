using Microsoft.Extensions.Caching.Memory;

namespace Soccer.Shared.Repositories;

public class CachedPlayerRepository : BaseRepo<Player>, IPlayerRepository
{
    private readonly PlayerRepository _decoratedPlayerRepository;
    private readonly IMemoryCache _cache;

    public CachedPlayerRepository(DbContext db, PlayerRepository teamRepository, IMemoryCache cache) : base(db)
    {
        _decoratedPlayerRepository = teamRepository;
        _cache = cache;
    }
    public async override Task<Player> GetByIdAsync(object id)
    {
        string cachedPlayerId = $"player-{id}";
        return await _cache.GetOrCreateAsync(id, entry =>
        {
            entry.SetAbsoluteExpiration(TimeSpan.FromMinutes(3));
            return _decoratedPlayerRepository.GetByIdAsync(id);
        });
    }
}