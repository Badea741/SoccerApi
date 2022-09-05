using CommonGenericClasses;
using Soccer.Shared.Entities;
using Soccer.Shared.Repositories;

namespace Soccer.Shared.UnitsOfWork;

public class TeamUnitOfWork : BaseUnitOfWork<Team> ,ITeamUnitOfWork
{
    public TeamUnitOfWork(ITeamRepository repo) : base(repo)
    {
    }
}
