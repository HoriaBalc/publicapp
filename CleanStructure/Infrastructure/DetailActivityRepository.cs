using Application;
using Infrastructure.Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DetailActivityRepository : IDetailActivityRepository
    {

        private readonly AppDbContext _context;

        public DetailActivityRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<DetailActivity> GetDetailActivity(Guid id)
        {
            var activity = await _context.DetailActivities.SingleOrDefaultAsync(s => s.Id == id);
            return activity;
        }
        public async Task<Guid> CreateDetailActivity(DetailActivity activity)
        {
            await _context.DetailActivities.AddAsync(activity);
            return activity.Id;
        }

        public async Task<DetailActivity> DeleteDetailActivity(DetailActivity activity)
        {
            _context.DetailActivities.Remove(activity);
            return activity;

        }

        public async Task<DetailActivity> UpdateDetailActivity(DetailActivity activity)
        {
            _context.DetailActivities.Update(activity);
            return activity;
        }

        public async Task<List<DetailActivity>> GetDetailActivities()
        {
          //var activityList = await _context.DetailActivities.Include(x => x.Activity).ToListAsync();
            var activityList = await _context.DetailActivities.ToListAsync();
            return activityList;
        }
    }
}
