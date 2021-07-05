using RIHGameLogic.Models.VersionOne;
using RIHGameLogic.Models.VersionOne.Devouts;
using RIHGameLogic.Models.VersionOne.Leaders;
using RIHGameLogic.Models.VersionOne.Minions.GreaterDemons;
using RIHGameLogic.Models.VersionOne.Minions.LesserDemons;
using RIHGameLogic.Models.VersionOne.Minions.SuperiorDemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RIHGameLogic.Services.VersionOne.Interfaces
{
    public interface IUnitsInformationServiceV1
    {
        public Warrior GetWarriorInformation();
        public Schemer GetSchemerInformation();
        public Zealot GetZealotInformation();
        public List<BaseUnit> GetAllLeadersInformation();
        public LordOfThePit GetLordOfThePitInformation();
        public Executioner GetExecutionerInformation();
        public MadnessDemon GetMadnessDemonInformation();
        public Tallyman GetTallymanInformation();
        public Succubus GetSuccubusInformation();
        public VoidDemon GetVoidDemonInformation();
        public List<BaseUnit> GetAllDevoutsInformation();
        public SlaughterFiend GetSlaughterFiendInformation();
        public Mephit GetMephitInformation();
        public TentacleBeast GetTentacleBeastInformation();
        public ArmoredDemon GetArmoredDemonInformation();
        public SpinedDemon GetSpinedDemonInformation();
        public CorpulentDemon GetCorpulentDemonInformation();
        public List<BaseUnit> GetAllLesserDemonsInformation();
        public TortureMaster GetTortureMasterInformation();
        public SerpentKnight GetSerpentKnightInformation();
        public MarquessDWinter GetMarquessDWinterInformation();
        public List<BaseUnit> GetAllGreaterDemonsInformation();
        public ShadowKing GetShadowKingInformation();
        public LordOfFlame GetLordOfFlameInformation();
        public VenomQueen GetVenomQueenInformation();
        public List<BaseUnit> GetAllSuperiorDemons();
        public List<BaseUnit> GetAllUnitsInformation();
    }
}
