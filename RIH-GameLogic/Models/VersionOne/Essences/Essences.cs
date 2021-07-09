using System;
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
        public int soulOfLightning()
        {
            return (int)Move.OneInch;
        }

        public int poisonedSoul(int naturalDiceRole)
        {
            if (naturalDiceRole == (int)NaturalRole.D6)
            {
                return (int)Damage.TwoDamage;
            }
            else
            {
                return (int)Damage.NoDamage;
            }
        }

        public int unyieldingEssence()
        {
            return (int)Life.TwoExtra;
        }

        public int explosiveSpirit()
        {
            return (int)Damage.OneDamage;
        }

        public int skirmishSpirit()
        {
            return (int)Move.ThreeInches;
        }

        public int regeneratingSoul()
        {
            return (int)Life.OneExtra;
        }
    }
}
