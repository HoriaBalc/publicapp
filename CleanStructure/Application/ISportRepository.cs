using Domain;

namespace Application;

public interface ISportRepository
{
    Sport GetSport(Guid id);
    void CreateSport(Sport sport);
}
