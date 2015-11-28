using ASPNET5SimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET5SimpleApp.Managers
{
    public class HeroManager
    {
        readonly List<DOTAHero> _heros = new List<DOTAHero>
        {
            new DOTAHero { ID = 1, Name = "Sniper", Type = "Agility" },
            new DOTAHero { ID = 2, Name="PA", Type="Agility" }
        };

        public IEnumerable<DOTAHero> GetAll()
        {
            return _heros;
        }

        public IEnumerable<DOTAHero> GetHerosByType(string type)
        {
            return _heros.Where(hero => hero.Type.ToLower().Equals(type.ToLower()));
        }
    }
}
