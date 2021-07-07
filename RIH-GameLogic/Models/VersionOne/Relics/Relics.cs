using RIHGameLogic.Models.VersionOne.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RIHGameLogic.Models.VersionOne.Enums.Combat;
using static RIHGameLogic.Models.VersionOne.Enums.DiceRole;
using static RIHGameLogic.Models.VersionOne.Enums.Movement;

namespace RIH_GameLogic.Models.VersionOne.Relics
{
    public class Relics
    {
        public int screamingShield(int possibleDamage)
        {
            if (possibleDamage < Convert.ToInt32(Damage.TwoDamage))
            {
                return Convert.ToInt32(Damage.NoDamage);
            }
            else
            {
                return possibleDamage;
            }
        }

        public int infernaalArmor(int incomingDamage)
        {
            return incomingDamage - Convert.ToInt32(Damage.OneDamage);
        }

        public int hammerOfThunder(int diceRole)
        {
            if (diceRole == Convert.ToInt32(NaturalRole.D6))
            {
                return Convert.ToInt32(Damage.TwoDamage);
            }
            else
            {
                return Convert.ToInt32(Damage.NoDamage);
            }
        }

        public int axeOfBlackBlood(int attackRole)
        {
            return attackRole + 1;
        }

        public int plateOfRimeIce(int DefenseRoll, int movement)
        {
            if (DefenseRoll == Convert.ToInt32(NaturalRole.D6))
            {
                return Convert.ToInt32(Move.None);
            }
            else
            {
                return movement;
            }
        }
    }   
}
