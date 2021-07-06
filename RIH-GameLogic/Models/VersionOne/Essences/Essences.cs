﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RIHGameLogic.Models.VersionOne.Enums.Movement;
using static RIHGameLogic.Models.VersionOne.Enums.Combat;
using static RIHGameLogic.Models.VersionOne.Enums.Health;
using static RIHGameLogic.Models.VersionOne.Enums.DiceRole;

namespace RIHGameLogic.Models.VersionOne.Essences
{
    public class Essences
    {
        //public int soulOfLightning { get; set; } = Convert.ToInt32(Move.OneInch);
        //public int poisonedSoul { get; set; } = Convert.ToInt32(Damage.OneExtra);
        //public int unyieldingEssence { get; set; } = Convert.ToInt32(Life.TwoExtra);
        //public int skirmishSpirit { get; set; } = Convert.ToInt32(Move.ThreeInches);
        //public int regeneratingSoul { get; set; } = Convert.ToInt32(Life.OneExtra);

        public int soulOfLightning()
        {
            return Convert.ToInt32(Move.OneInch);
        }

        public int poisonedSoul(int naturalDiceRole)
        {
            if (naturalDiceRole == Convert.ToInt32(NaturalRole.D6))
            {
                return Convert.ToInt32(Damage.TwoDamage);
            }
            else
            {
                return Convert.ToInt32(Damage.NoDamage);
            }
        }

        public int unyieldingEssence()
        {
            return Convert.ToInt32(Life.TwoExtra);
        }
    }
}