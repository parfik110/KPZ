using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Library
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public ICharacterBuilder SetName(string name) { _character.Name = name; return this; }
        public ICharacterBuilder SetHeight(string height) { _character.Height = height; return this; }
        public ICharacterBuilder SetBodyType(string bodyType) { _character.BodyType = bodyType; return this; }
        public ICharacterBuilder SetHairColor(string hairColor) { _character.HairColor = hairColor; return this; }
        public ICharacterBuilder SetEyeColor(string eyeColor) { _character.EyeColor = eyeColor; return this; }
        public ICharacterBuilder SetOutfit(string outfit) { _character.Outfit = outfit; return this; }
        public ICharacterBuilder AddToInventory(string item) { _character.Inventory.Add(item); return this; }
        public ICharacterBuilder AddAction(string action) { _character.Actions.Add(action); return this; }
        public Character Build() { return _character; }
    }
}
