using Domain;

namespace Application;

public interface ISportRepository
{
    Sport GetSport(string name);
    void CreateSport(Sport sport);
}
