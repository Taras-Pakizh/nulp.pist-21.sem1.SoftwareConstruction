using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot.Common;
using static BogdanDuben.RobotChallenge.DistanceHelper;

namespace BogdanDuben.RobotChallenge.Test
{
    [TestClass]
    public class TestDistanceHelper
    {
        [TestMethod]
        public void TestDistance()
        {
            var p1 = new Position(1, 1);
            var p2 = new Position(2, 4);
            Assert.AreEqual(10, FindDistance(p1, p2));
        }
    }

}
