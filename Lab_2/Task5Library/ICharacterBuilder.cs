using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Library
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetHeight(string height);
        ICharacterBuilder SetBodyType(string bodyType);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetOutfit(string outfit);
        ICharacterBuilder AddToInventory(string item);
        ICharacterBuilder AddAction(string action);
        Character Build();
    }
}
