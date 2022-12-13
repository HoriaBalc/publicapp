using Domain;

namespace Application;

public interface ISportRepository
{
    Task<Sport> GetSport(string name);
    Task<List<Sport>> GetSports();
    Task<string> CreateSport(Sport sport);
    Task<Sport> DeleteSport(Sport sport);
    Task<Sport> UpdateSport(Sport sport);

}
