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
    public class SportRepository : ISportRepository
    {

        private readonly AppDbContext _context;

        public SportRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Sport> GetSport(string name)
        {
            var sport= await _context.Sports.SingleOrDefaultAsync(s => s.Name == name);
            return sport;
        }

        public async Task<List<Sport>> GetSports()
        {
            var sportList = await _context.Sports.Take(100).ToListAsync();
            return sportList;
        }

        public async Task<string> CreateSport(Sport sport)
        {
            await _context.Sports.AddAsync(sport); 
            //_context.SaveChanges(); 
            return sport.Name;
        }

        public async Task<Sport> DeleteSport(Sport sport)
        {
            _context.Sports.Remove(sport);
            return sport;
        }

        public async Task<Sport> UpdateSport(Sport sport)
        {   
            _context.Sports.Update(sport);
            return sport;
        }


    }
}
