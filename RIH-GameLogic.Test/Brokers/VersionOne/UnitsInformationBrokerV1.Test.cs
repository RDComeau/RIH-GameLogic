using KellermanSoftware.CompareNetObjects;
using Moq;
using NUnit.Framework;
using RIH_GameLogic.Brokers.VersionOne;
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

namespace RIH_GameLogic.Test.Brokers.VersionOne
{
    [TestFixture]
    public class UnitsInformationBrokerV1Test
    {
        private UnitsInformationBrokerV1 _broker;
        Mock<IUnitsInformationServiceV1> _servie;

        [SetUp]
        public void Setup()
        {
            _servie = new Mock<IUnitsInformationServiceV1>();
            _broker = new UnitsInformationBrokerV1(_servie.Object);
        }

        #region Leaders
        [Test]
        public void GetWarriorInformation_ShouldReturnWarriorInformationToController_WhenInvoked()
        {
            //Arrange
            Warrior expectedUnit = new Warrior();

            _servie.Setup(x => x.GetWarriorInformation())
                .Returns(expectedUnit);

            //Act
            Warrior actaulUnit = _broker.GetWarriorInformation();

            //Assert
            _servie.Verify(x => x.GetWarriorInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetSchemerInformation_ShouldReturnSchemerInformationToController_WhenInvoked()
        {
            //Arrange
            Schemer expectedUnit = new Schemer();

            _servie.Setup(x => x.GetSchemerInformation())
                .Returns(expectedUnit);

            //Act
            Schemer actaulUnit = _broker.GetSchemerInformation();

            //Assert
            _servie.Verify(x => x.GetSchemerInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetZealotInformation_ShouldReturnZealotInformationToController_WhenInvoked()
        {
            //Arrange
            Zealot expectedUnit = new Zealot();

            _servie.Setup(x => x.GetZealotInformation())
                .Returns(expectedUnit);

            //Act
            Zealot actaulUnit = _broker.GetZealotInformation();

            //Assert
            _servie.Verify(x => x.GetZealotInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetAllLeadersInformation_ShouldReturnLeadersInformationToController_WhenInvoked()
        {
            //Arrange
            List<BaseUnit> expectedUnit = new List<BaseUnit>()
            {
                new Warrior(),
                new Schemer(),
                new Zealot()
            };

            _servie.Setup(x => x.GetAllLeadersInformation())
                .Returns(expectedUnit);

            //Act
            List<BaseUnit> actaulUnit = _broker.GetAllLeadersInformation();

            //Assert
            _servie.Verify(x => x.GetAllLeadersInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }
        #endregion

        #region Devouts
        [Test]
        public void GetLordOfThePitInformation_ShouldReturnLordOfThePitInformationToController_WhenInvoked()
        {
            //Arrange
            LordOfThePit expectedUnit = new LordOfThePit();

            _servie.Setup(x => x.GetLordOfThePitInformation())
                .Returns(expectedUnit);

            //Act
            LordOfThePit actaulUnit = _broker.GetLordOfThePitInformation();

            //Assert
            _servie.Verify(x => x.GetLordOfThePitInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetExecutionerInformation_ShouldReturnExecutionerInformationToController_WhenInvoked()
        {
            //Arrange
            Executioner expectedUnit = new Executioner();

            _servie.Setup(x => x.GetExecutionerInformation())
                .Returns(expectedUnit);

            //Act
            Executioner actaulUnit = _broker.GetExecutionerInformation();

            //Assert
            _servie.Verify(x => x.GetExecutionerInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetMadnessDemonInformation_ShouldReturnMadnessDeamonInformationToController_WhenInvoked()
        {
            //Arrange
            MadnessDemon expectedUnit = new MadnessDemon();

            _servie.Setup(x => x.GetMadnessDemonInformation())
                .Returns(expectedUnit);

            //Act
            MadnessDemon actaulUnit = _broker.GetMadnessDemonInformation();

            //Assert
            _servie.Verify(x => x.GetMadnessDemonInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetTallymanInformation_ShouldReturnTallymanInformationToController_WhenInvoked()
        {
            //Arrange
            Tallyman expectedUnit = new Tallyman();

            _servie.Setup(x => x.GetTallymanInformation())
                .Returns(expectedUnit);

            //Act
            Tallyman actaulUnit = _broker.GetTallymanInformation();

            //Assert
            _servie.Verify(x => x.GetTallymanInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetSuccubusInformation_ShouldReturnSuccubusInformationToController_WhenInvoked()
        {
            //Arrange
            Succubus expectedUnit = new Succubus();

            _servie.Setup(x => x.GetSuccubusInformation())
                .Returns(expectedUnit);

            //Act
            Succubus actaulUnit = _broker.GetSuccubusInformation();

            //Assert
            _servie.Verify(x => x.GetSuccubusInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetVoidDemonInformation_ShouldReturnVoidDemonInformationToController_WhenInvoked()
        {
            //Arrange
            VoidDemon expectedUnit = new VoidDemon();

            _servie.Setup(x => x.GetVoidDemonInformation())
                .Returns(expectedUnit);

            //Act
            VoidDemon actaulUnit = _broker.GetVoidDemonInformation();

            //Assert
            _servie.Verify(x => x.GetVoidDemonInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetAllDevoutsInformation_ShouldReturnDevoutsInformationToController_WhenInvoked()
        {
            //Arrange
            List<BaseUnit> expectedUnit = new List<BaseUnit>()
            {
                new LordOfThePit(),
                new Executioner(),
                new MadnessDemon(),
                new Tallyman(),
                new Succubus(),
                new VoidDemon()
            };

            _servie.Setup(x => x.GetAllDevoutsInformation())
                .Returns(expectedUnit);

            //Act
            List<BaseUnit> actaulUnit = _broker.GetAllDevoutsInformation();

            //Assert
            _servie.Verify(x => x.GetAllDevoutsInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }
        #endregion

        #region Minions: Lesser Demons
        [Test]
        public void GetSlaughterFiendInformation_ShouldReturnSlaughterFiendInformationToController_WhenInvoked()
        {
            //Arrange
            SlaughterFiend expectedUnit = new SlaughterFiend();

            _servie.Setup(x => x.GetSlaughterFiendInformation())
                .Returns(expectedUnit);

            //Act
            SlaughterFiend actaulUnit = _broker.GetSlaughterFiendInformation();

            //Assert
            _servie.Verify(x => x.GetSlaughterFiendInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetMephitInformation_ShouldReturnMephitInformationToController_WhenInvoked()
        {
            //Arrange
            Mephit expectedUnit = new Mephit();

            _servie.Setup(x => x.GetMephitInformation())
                .Returns(expectedUnit);

            //Act
            Mephit actaulUnit = _broker.GetMephitInformation();

            //Assert
            _servie.Verify(x => x.GetMephitInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetTentacleBeastInformation_ShouldReturnTentacleBeastInformationToController_WhenInvoked()
        {
            //Arrange
            TentacleBeast expectedUnit = new TentacleBeast();

            _servie.Setup(x => x.GetTentacleBeastInformation())
                .Returns(expectedUnit);

            //Act
            TentacleBeast actaulUnit = _broker.GetTentacleBeastInformation();

            //Assert
            _servie.Verify(x => x.GetTentacleBeastInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetArmoredDemonInformation_ShouldReturnArmoredDemonInformationToController_WhenInvoked()
        {
            //Arrange
            ArmoredDemon expectedUnit = new ArmoredDemon();

            _servie.Setup(x => x.GetArmoredDemonInformation())
                .Returns(expectedUnit);

            //Act
            ArmoredDemon actaulUnit = _broker.GetArmoredDemonInformation();

            //Assert
            _servie.Verify(x => x.GetArmoredDemonInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetSpinedDemonInformation_ShouldReturnSpinedDemonInformationToController_WhenInvoked()
        {
            //Arrange
            SpinedDemon expectedUnit = new SpinedDemon();

            _servie.Setup(x => x.GetSpinedDemonInformation())
                .Returns(expectedUnit);

            //Act
            SpinedDemon actaulUnit = _broker.GetSpinedDemonInformation();

            //Assert
            _servie.Verify(x => x.GetSpinedDemonInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetCorpulentDemonInformation_ShouldReturnCorpulentDemonInformationToController_WhenInvoked()
        {
            //Arrange
            CorpulentDemon expectedUnit = new CorpulentDemon();

            _servie.Setup(x => x.GetCorpulentDemonInformation())
                .Returns(expectedUnit);

            //Act
            CorpulentDemon actaulUnit = _broker.GetCorpulentDemonInformation();

            //Assert
            _servie.Verify(x => x.GetCorpulentDemonInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetAllLesserDemonsInformation_ShouldReturnAllLesserDemonsInformationToController_WhenInvoked()
        {
            //Arrange
            List<BaseUnit> expectedUnit = new List<BaseUnit>()
            {
                new SlaughterFiend(),
                new Mephit(),
                new TentacleBeast(),
                new ArmoredDemon(),
                new SpinedDemon(),
                new CorpulentDemon()
            };

            _servie.Setup(x => x.GetAllLesserDemonsInformation())
                .Returns(expectedUnit);

            //Act
            List<BaseUnit> actaulUnit = _broker.GetAllLesserDemonsInformation();

            //Assert
            _servie.Verify(x => x.GetAllLesserDemonsInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }
        #endregion

        #region Minions: Greater Demons
        [Test]
        public void GetTortureMasterInformation_ShouldReturnTortureMasterInformationToController_WhenInvoked()
        {
            //Arrange
            TortureMaster expectedUnit = new TortureMaster();

            _servie.Setup(x => x.GetTortureMasterInformation())
                .Returns(expectedUnit);

            //Act
            TortureMaster actaulUnit = _broker.GetTortureMasterInformation();

            //Assert
            _servie.Verify(x => x.GetTortureMasterInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetSerpentKnightInformation_ShouldReturnSerpentKnightInformationToController_WhenInvoked()
        {
            //Arrange
            SerpentKnight expectedUnit = new SerpentKnight();

            _servie.Setup(x => x.GetSerpentKnightInformation())
                .Returns(expectedUnit);

            //Act
            SerpentKnight actaulUnit = _broker.GetSerpentKnightInformation();

            //Assert
            _servie.Verify(x => x.GetSerpentKnightInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetMarquessDWinterInformation_ShouldReturnMarquessDWinterInformationToController_WhenInvoked()
        {
            //Arrange
            MarquessDWinter expectedUnit = new MarquessDWinter();

            _servie.Setup(x => x.GetMarquessDWinterInformation())
                .Returns(expectedUnit);

            //Act
            MarquessDWinter actaulUnit = _broker.GetMarquessDWinterInformation();

            //Assert
            _servie.Verify(x => x.GetMarquessDWinterInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetAllGreaterDemonsInformation_ShouldReturnAllGreaterDemonsInformationToController_WhenInvoked()
        {
            //Arrange
            List<BaseUnit> expectedUnit = new List<BaseUnit>()
            {
                new TortureMaster(),
                new SerpentKnight(),
                new MarquessDWinter()
            };

            _servie.Setup(x => x.GetAllGreaterDemonsInformation())
                .Returns(expectedUnit);

            //Act
            List<BaseUnit> actaulUnit = _broker.GetAllGreaterDemonsInformation();

            //Assert
            _servie.Verify(x => x.GetAllGreaterDemonsInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }
        #endregion

        #region Minions: Superior Demons
        [Test]
        public void GetShadowKingInformation_ShouldReturnShadowKingInformationToController_WhenInvoked()
        {
            //Arrange
            ShadowKing expectedUnit = new ShadowKing();

            _servie.Setup(x => x.GetShadowKingInformation())
                .Returns(expectedUnit);

            //Act
            ShadowKing actaulUnit = _broker.GetShadowKingInformation();

            //Assert
            _servie.Verify(x => x.GetShadowKingInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetLordOfFlameInformation_ShouldReturnLordOfFlameInformationToController_WhenInvoked()
        {
            //Arrange
            LordOfFlame expectedUnit = new LordOfFlame();

            _servie.Setup(x => x.GetLordOfFlameInformation())
                .Returns(expectedUnit);

            //Act
            LordOfFlame actaulUnit = _broker.GetLordOfFlameInformation();

            //Assert
            _servie.Verify(x => x.GetLordOfFlameInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetVenomQueenInformation_ShouldReturnVenomQueenInformationToController_WhenInvoked()
        {
            //Arrange
            VenomQueen expectedUnit = new VenomQueen();

            _servie.Setup(x => x.GetVenomQueenInformation())
                .Returns(expectedUnit);

            //Act
            VenomQueen actaulUnit = _broker.GetVenomQueenInformation();

            //Assert
            _servie.Verify(x => x.GetVenomQueenInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }

        [Test]
        public void GetAllSuperiorDemonsInformation_ShouldReturnAllSuperiorDemonsInformationToController_WhenInvoked()
        {
            //Arrange
            List<BaseUnit> expectedUnit = new List<BaseUnit>()
            {
                new ShadowKing(),
                new LordOfFlame(),
                new VenomQueen()
            };

            _servie.Setup(x => x.GetAllSuperiorDemonsInformation())
                .Returns(expectedUnit);

            //Act
            List<BaseUnit> actaulUnit = _broker.GetAllSuperiorDemonsInformation();

            //Assert
            _servie.Verify(x => x.GetAllSuperiorDemonsInformation(), Times.Once);

            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }
        #endregion

        [Test]
        public void GetAllUnitsInformation_ShouldReturnAllUnitsInformationToController_WhenInvoked()
        {
            List<BaseUnit> leaders = new List<BaseUnit>();

            //Arrange
            List<BaseUnit> expectedUnit = new List<BaseUnit>()
            {
                new Warrior(),
                new Schemer(),
                new Zealot(),
                new LordOfThePit(),
                new Executioner(),
                new MadnessDemon(),
                new Tallyman(),
                new Succubus(),
                new VoidDemon(),
                new SlaughterFiend(),
                new Mephit(),
                new TentacleBeast(),
                new ArmoredDemon(),
                new SpinedDemon(),
                new CorpulentDemon(),
                new TortureMaster(),
                new SerpentKnight(),
                new MarquessDWinter(),
                new ShadowKing(),
                new LordOfFlame(),
                new VenomQueen()
            };

            //Act
            List<BaseUnit> actaulUnit = _broker.GetAllUnitsInformation();

            //Assert
            CompareLogic compare = new CompareLogic();
            ComparisonResult comparisonResult = compare.Compare(expectedUnit, actaulUnit);
            Assert.IsTrue(comparisonResult.AreEqual, comparisonResult.DifferencesString);
        }
    }
}
