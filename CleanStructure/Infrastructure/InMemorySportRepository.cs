using Application;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class InMemorySportRepository : ISportRepository
    {
        //private readonly List<Sport> _sports = new();

        //public Sport GetSport(string name) 
        //{
        //    foreach(Sport sport in _sports){
        //        if(sport.Name.Equals(name))
        //            return sport;
        //    }
        //    return new Sport(name);
        //}
        //public Guid CreateSport(string nameSport) 
        //{
        //    var sport = new Sport(nameSport);
        //    _sports.Add(sport);
        //    return sport.Id;
        //}

        private readonly AppDbContext _context;

        public InMemorySportRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Sport> GetSport(string name)
        {
            var sport= await _context.Sports.SingleOrDefaultAsync(s => s.Name == name);
            return sport;
        }

        public async Task<string> CreateSport(Sport sport)
        {
            //Sport sport = await GetSport(nameSport);
            //var s = new Sport(sport.Name);
            //await _context.Sports.AddAsync(s);
            //return sport;
           // var sportDto = new SportDTO(sport);

            await _context.Sports.AddAsync(sport); 
            _context.SaveChanges(); 
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
