using Microsoft.Extensions.Caching.Memory;

namespace Soccer.Shared.Repositories;
public class CachedTeamRepository : BaseRepo<Team>, ITeamRepository
{
    private readonly TeamRepository _decoratedTeamRepository;
    private readonly IMemoryCache _cache;

    public CachedTeamRepository(DbContext db, TeamRepository decoratedTeamRepository, IMemoryCache cache) : base(db)
    {
        _decoratedTeamRepository = decoratedTeamRepository;
        _cache = cache;
    }
    public async override Task<Team> GetByIdAsync(object id)
    {
        string cacheTeamId = $"team-{id}";
        return await _cache.GetOrCreateAsync<Team>(cacheTeamId,entry=>{
            entry.SetAbsoluteExpiration(TimeSpan.FromMinutes(3));
            return _decoratedTeamRepository.GetByIdAsync(id);
        });
    }
}