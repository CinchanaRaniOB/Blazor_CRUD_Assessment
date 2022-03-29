using SuperHeroDB.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroDB.Client.Service
{
    public interface ISuperHeroService
    {
        event Action Onchange;
        List<Comic> Comics { get; set; }
        List<SuperHero> Heroes { get; set; }
        public Task<List<SuperHero>> GetSuperHeroes();
        Task GetComics();
        public Task<SuperHero> GetSuperHero(int id);
        Task<List<SuperHero>> CreateSuperHero(SuperHero hero);
        Task<List<SuperHero>> UpdateSuperHero(SuperHero hero, int id);
        Task<List<SuperHero>> DeleteSuperHero(int id);
    }
}
