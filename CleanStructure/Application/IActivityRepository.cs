using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IActivityRepository
    {
        Task<Activity> GetActivity(Guid id);
        Task<List<Activity>> GetActivities();
        Task<Guid> CreateActivity(Activity activity);
        Task<Activity> DeleteActivity(Activity activity);
        Task<Activity> UpdateActivity(Activity activity);
    }
}
