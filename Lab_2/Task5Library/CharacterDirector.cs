using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Library
{
    public class CharacterDirector
    {
        public Character CreateHero(ICharacterBuilder builder)
        {
            return builder.SetName("Sung Jin-Woo")
                          .SetHeight("178 cm")
                          .SetBodyType("Athletic")
                          .SetHairColor("Black")
                          .SetEyeColor("Dark")
                          .SetOutfit("Black Hunter Suit")
                          .AddToInventory("Kamish's Wrath")
                          .AddToInventory("Shadow Soldiers")
                          .AddAction("Command Shadows")
                          .AddAction("Fight for humanity")
                          .Build();
        }

        public Character CreateEnemy(ICharacterBuilder builder)
        {
            return builder.SetName("Azazel the Fallen")
                          .SetHeight("210 cm")
                          .SetBodyType("Monstrous")
                          .SetHairColor("White")
                          .SetEyeColor("Glowing Red")
                          .SetOutfit("Darkened Armor")
                          .AddToInventory("Demonic Spear")
                          .AddToInventory("Wings of Ruin")
                          .AddAction("Destroy worlds")
                          .AddAction("Summon legions of demons")
                          .Build();
        }
    }

}
