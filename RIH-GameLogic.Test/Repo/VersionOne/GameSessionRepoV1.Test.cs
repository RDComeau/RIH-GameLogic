using Moq;
using NUnit.Framework;
using RIH_GameLogic.Helpers.Interfaces;
using RIH_GameLogic.Repo.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIH_GameLogic.Test.Repo.VersionOne
{
    [TestFixture]
    public class GameSessionRepoV1Test
    {
        IGameSessionRepoV1 _gameSession;
        Mock<IConfigHelper> _configHelper;

        [SetUp]
        public void Setup()
        {

        }

        [TearDown]
        public void Teardown()
        {

        }

        [Test]
        public void CreateNewSession_CreateGameSession_WhenInvoked()
        {

        }
    }
}
