using Domain;

namespace Application;

public interface ISportRepository
{
    Sport GetSport(string name);
    Guid CreateSport(string nameSport);
}
