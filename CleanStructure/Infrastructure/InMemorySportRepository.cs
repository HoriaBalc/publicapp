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
        public Sport GetSport(string name) 
        {
            foreach(Sport sport in _sports){
                if(sport.Name.Equals(name))
                    return sport;
            }
            return new Sport(name);
        }
        public void CreateSport(Sport sport) 
        {
            _sports.Add(sport);
        }
    }
}
