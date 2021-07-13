using RIH_GameLogic.Brokers.VersionOne.Interfaces;
using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Devouts;
using RIH_GameLogic.Models.VersionOne.Leaders;
using RIH_GameLogic.Models.VersionOne.Minions.GreaterDemons;
using RIH_GameLogic.Models.VersionOne.Minions.LesserDemons;
using RIH_GameLogic.Models.VersionOne.Minions.SuperiorDemons;
using RIH_GameLogic.Services.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Brokers.VersionOne
{

    public class UnitsInformationBrokerV1 : IUnitsInformationBrokerV1
    {
        private IUnitsInformationServiceV1 _service;

        public UnitsInformationBrokerV1(IUnitsInformationServiceV1 service)
        {
            _service = service;
        }

        #region Leaders
        public Warrior GetWarriorInformation()
        {
            return _service.GetWarriorInformation();
        }

        public Schemer GetSchemerInformation()
        {
            return _service.GetSchemerInformation();
        }

        public Zealot GetZealotInformation()
        {
            return _service.GetZealotInformation();
        }

        public List<BaseUnit> GetAllLeadersInformation()
        {
            return _service.GetAllLeadersInformation();
        }
        #endregion

        #region Devouts
        public LordOfThePit GetLordOfThePitInformation()
        {
            return _service.GetLordOfThePitInformation();
        }

        public Executioner GetExecutionerInformation()
        {
            return _service.GetExecutionerInformation();
        }

        public MadnessDemon GetMadnessDemonInformation()
        {
            return _service.GetMadnessDemonInformation();
        }

        public Tallyman GetTallymanInformation()
        {
            return _service.GetTallymanInformation();
        }

        public Succubus GetSuccubusInformation()
        {
            return _service.GetSuccubusInformation();
        }

        public VoidDemon GetVoidDemonInformation()
        {
            return _service.GetVoidDemonInformation();
        }

        public List<BaseUnit> GetAllDevoutsInformation()
        {
            return _service.GetAllDevoutsInformation();
        }
        #endregion

        #region Minions: Lesser Demons
        public SlaughterFiend GetSlaughterFiendInformation()
        {
            return _service.GetSlaughterFiendInformation();
        }

        public Mephit GetMephitInformation()
        {
            return _service.GetMephitInformation();
        }

        public TentacleBeast GetTentacleBeastInformation()
        {
            return _service.GetTentacleBeastInformation();
        }

        public ArmoredDemon GetArmoredDemonInformation()
        {
            return _service.GetArmoredDemonInformation();
        }

        public SpinedDemon GetSpinedDemonInformation()
        {
            return _service.GetSpinedDemonInformation();
        }

        public CorpulentDemon GetCorpulentDemonInformation()
        {
            return _service.GetCorpulentDemonInformation();
        }

        public List<BaseUnit> GetAllLesserDemonsInformation()
        {
            return _service.GetAllLesserDemonsInformation();
        }
        #endregion

        #region Minions: Greater Demons
        public TortureMaster GetTortureMasterInformation()
        {
            return _service.GetTortureMasterInformation();
        }

        public SerpentKnight GetSerpentKnightInformation()
        {
            return _service.GetSerpentKnightInformation();
        }

        public MarquessDWinter GetMarquessDWinterInformation()
        {
            return _service.GetMarquessDWinterInformation();
        }

        public List<BaseUnit> GetAllGreaterDemonsInformation()
        {
            return _service.GetAllGreaterDemonsInformation();
        }
        #endregion

        #region Minions: Superior Demons
        public ShadowKing GetShadowKingInformation()
        {
            return _service.GetShadowKingInformation();
        }

        public LordOfFlame GetLordOfFlameInformation()
        {
            return _service.GetLordOfFlameInformation();
        }

        public VenomQueen GetVenomQueenInformation()
        {
            return _service.GetVenomQueenInformation();
        }

        public List<BaseUnit> GetAllSuperiorDemonsInformation()
        {
            return _service.GetAllSuperiorDemonsInformation();
        }
        #endregion

        #region All Units
        public List<BaseUnit> GetAllUnitsInformation()
        {
            List<BaseUnit> allUnits = new List<BaseUnit>();
            allUnits.AddRange(GetAllLeadersInformation());
            allUnits.AddRange(GetAllDevoutsInformation());
            allUnits.AddRange(GetAllLesserDemonsInformation());
            allUnits.AddRange(GetAllGreaterDemonsInformation());
            allUnits.AddRange(GetAllSuperiorDemonsInformation());

            return allUnits;
        }
        #endregion


    }
}
