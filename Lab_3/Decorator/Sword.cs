using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Sword : HeroDecorator
    {
        public Sword(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " with Sword";
        public override int GetPower() => hero.GetPower() + 5;
    }
}
