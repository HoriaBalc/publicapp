using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public interface IPaceActivityRepository
    {
        Task<PaceActivity> GetPaceActivity(Guid id);
        Task<List<PaceActivity>> GetPaceActivities();
        Task<Guid> CreatePaceActivity(PaceActivity activity);
        Task<PaceActivity> DeletePaceActivity(PaceActivity activity);
        Task<PaceActivity> UpdatePaceActivity(PaceActivity activity);

    }
}
