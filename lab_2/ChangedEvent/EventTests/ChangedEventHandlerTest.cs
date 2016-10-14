using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot.Common;
using RobotChallengeChangeEvent;
using static RobotChallengeChangeEvent.Command;

namespace EventTests
{
    [TestClass]
    public class ChangedEventHandlerTest
    {
        [TestMethod]
        public void Test1()
        {
            ChangedEventHandler a = null;
            a += CollectEnergy;
            RobotCommand res = a(new List<Robot.Common.Robot>(), 1, new Map());
            Assert.AreEqual(new CollectEnergyCommand(), res);
        }

        [TestMethod]
        public void Test2()
        {
            ChangedEventHandler a = null;
            a += Stay;
            RobotCommand res = a(new List<Robot.Common.Robot>(), 1, new Map());
            Assert.AreEqual(null, res);
        }

        [TestMethod]
        public void Test3()
        {
            ChangedEventHandler a = null;
            a += CreateNewRobot;
            RobotCommand res = a(new List<Robot.Common.Robot>(), 1, new Map());
            Assert.AreEqual(new CreateNewRobotCommand(), res);
        }

        [TestMethod]
        public void Test4()
        {
            ChangedEventHandler a = null;
            a += Move;
            RobotCommand res = a(new List<Robot.Common.Robot>(), 1, new Map());
            Assert.AreEqual(new MoveCommand(), res);
        }
    }
}
