using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static BogdanDuben.RobotChallenge.Util;
using Robot.Common;

namespace BogdanDuben.RobotChallenge.Test
{

    [TestClass]
    public class TestUtil
    {

        [TestMethod]
        public void RobotCountTest()
        {
            var map = new Map();
            var robots = new List<Robot.Common.Robot> {
                new Robot.Common.Robot() {Position = new Position(5, 5) },
                new Robot.Common.Robot() {Position = new Position(0, 0) },
                new Robot.Common.Robot() {Position = new Position(4, 5) },
                new Robot.Common.Robot() {Position = new Position(5, 4) },
                new Robot.Common.Robot() {Position = new Position(4, 4) },
                new Robot.Common.Robot() {Position = new Position(3, 5) },
                new Robot.Common.Robot() {Position = new Position(5, 3) },
                new Robot.Common.Robot() {Position = new Position(4, 3) },
                new Robot.Common.Robot() {Position = new Position(3, 4) },
                new Robot.Common.Robot() {Position = new Position(6, 8) },
            };
            var position = new Position(5, 5);
            int count = RobotCount(map, robots, position);
            Assert.AreEqual(6, count);
        }

    }

}
