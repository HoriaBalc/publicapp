using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class InMemoryDetailActivityRepository : IDetailActivityRepository
    {
        private readonly List<DetailActivity> _detailsActivity = new();
        public DetailActivity GetDetailActivity(Guid id)
        {
            foreach (DetailActivity detail in _detailsActivity)
            {
                if (detail.Id.Equals(id))
                    return detail;
            }
            return new DetailActivity();
        }
        public void CreateDetailActivity(DetailActivity detail)
        {
            _detailsActivity.Add(detail);
        }
    }
}
