using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IDetailActivityRepository
    {
        Task<DetailActivity> GetDetailActivity(Guid id);
        Task<List<DetailActivity>> GetDetailActivities();
        Task<Guid> CreateDetailActivity(DetailActivity detailActivity);
        Task<DetailActivity> DeleteDetailActivity(DetailActivity detailActivity);
        Task<DetailActivity> UpdateDetailActivity(DetailActivity detailActivity);
    }
}
