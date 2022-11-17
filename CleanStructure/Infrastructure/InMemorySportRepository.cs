using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class InMemorySportRepository : ISportRepository
    {
        private readonly List<Sport> _sports = new();
        public Sport GetSport(Guid id) 
        {
            foreach(Sport sport in _sports){
                return sport;
            }
            return null;
        }
        public void CreateSport(Sport sport) 
        {
            _sports.Add(sport);
        }
    }
}
