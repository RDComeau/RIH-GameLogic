using RIH_GameLogic.Models.VersionOne.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.Combat;
using static RIH_GameLogic.Models.VersionOne.Enums.DiceRole;
using static RIH_GameLogic.Models.VersionOne.Enums.Movement;

namespace RIH_GameLogic.Models.VersionOne.Relics
{
    public class Relics
    {
        public int screamingShield(int possibleDamage)
        {
            if (possibleDamage < (int)Damage.TwoDamage)
            {
                return (int)Damage.NoDamage;
            }
            else
            {
                return possibleDamage;
            }
        }

        public int infernaalArmor(int incomingDamage)
        {
            return incomingDamage - (int)Damage.OneDamage;
        }

        public int hammerOfThunder(int diceRole)
        {
            if (diceRole == (int)NaturalRole.D6)
            {
                return (int)Damage.TwoDamage;
            }
            else
            {
                return (int)Damage.NoDamage;
            }
        }

        public int axeOfBlackBlood(int attackRole)
        {
            return attackRole + 1;
        }

        public int plateOfRimeIce(int DefenseRoll, int movement)
        {
            if (DefenseRoll == (int)NaturalRole.D6)
            {
                return (int)Move.None;
            }
            else
            {
                return movement;
            }
        }
    }   
}
