using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Artifact : HeroDecorator
    {
        public Artifact(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " with Artifact";
        public override int GetPower() => hero.GetPower() + 7;
    }
}
