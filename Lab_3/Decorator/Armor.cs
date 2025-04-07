using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Armor : HeroDecorator
    {
        public Armor(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " with Armor";
        public override int GetPower() => hero.GetPower() + 3;
    }
}
