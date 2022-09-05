using CommonGenericClasses;
using Soccer.Shared.Entities;
using Soccer.Shared.Repositories;

namespace Soccer.Shared.UnitsOfWork;
public class PlayerUnitOfWork : BaseUnitOfWork<Player>, IPlayerUnitOfWork
{
    public PlayerUnitOfWork(IPlayerRepository repo) : base(repo)
    {
    }

}
