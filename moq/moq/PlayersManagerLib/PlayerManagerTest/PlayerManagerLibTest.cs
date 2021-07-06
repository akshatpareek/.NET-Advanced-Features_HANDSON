﻿using Moq;
using NUnit.Framework;
using PlayersManagerLib;
using System;

namespace PlayerManagerTest
{
    [TestFixture]
    public class PlayersManagerLibTest
    {
        Mock<IPlayerMapper> _mock;

        [OneTimeSetUp]
        public void Init()
        {
            _mock = new Mock<IPlayerMapper>(MockBehavior.Loose);
        }

        [Test]
        [TestCase("Project")]
        [TestCase("Test")]
        [TestCase("run")]
        public void RegisterNewPlayer_whencalled_RegisterANewPlayer(string name)
        {
            _mock.Setup(p => p.IsPlayerNameExistsInDb(name)).Returns(false);
            Player result = Player.RegisterNewPlayer(name, _mock.Object);
            NUnit.Framework.Assert.AreEqual(result.Name, name);

        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("  ")]
        public void RegisterNewPlayer_whencalled_ReturnsArgumentException(string name)
        {
            NUnit.Framework.Assert.That(() => Player.RegisterNewPlayer(name, _mock.Object), Throws.ArgumentException);
            //Player result = Player.RegisterNewPlayer(name, _mock.Object);

        }
    }
}
