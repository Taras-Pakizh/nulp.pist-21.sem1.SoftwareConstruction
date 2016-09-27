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
            var robots = new List<Robot.Common.Robot> {
                new Robot.Common.Robot() {Position = new Position(5, 5) },
                new Robot.Common.Robot() {Position = new Position(0, 0) },
                new Robot.Common.Robot() {Position = new Position(4, 5) },
                new Robot.Common.Robot() {Position = new Position(5, 4) },
                new Robot.Common.Robot() {Position = new Position(4, 4) },
                new Robot.Common.Robot() {Position = new Position(3, 5) },
                new Robot.Common.Robot() {Position = new Position(5, 6) },
                new Robot.Common.Robot() {Position = new Position(4, 3) },
                new Robot.Common.Robot() {Position = new Position(3, 4) },
                new Robot.Common.Robot() {Position = new Position(6, 8) },
            };
            var position = new Position(5, 5);
            int count = RobotCount(robots, position);
            Assert.AreEqual(4, count);
        }

        [TestMethod]
        public void MyRobotCountTest()
        {
            var me = new Owner();
            var robots = new List<Robot.Common.Robot> {
                new Robot.Common.Robot() {Position = new Position(5, 5), Owner=me},
                new Robot.Common.Robot() {Position = new Position(0, 0) },
                new Robot.Common.Robot() {Position = new Position(4, 5) },
                new Robot.Common.Robot() {Position = new Position(5, 4) },
                new Robot.Common.Robot() {Position = new Position(4, 4) },
                new Robot.Common.Robot() {Position = new Position(3, 5) },
                new Robot.Common.Robot() {Position = new Position(5, 6), Owner=me },
                new Robot.Common.Robot() {Position = new Position(4, 3) },
                new Robot.Common.Robot() {Position = new Position(3, 4) },
                new Robot.Common.Robot() {Position = new Position(6, 8) },
            };
            var position = new Position(5, 5);
            int count = MyRobotCount(robots, position, me);
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void EnemysRobotCountTest()
        {
            var me = new Owner();
            var robots = new List<Robot.Common.Robot> {
                new Robot.Common.Robot() {Position = new Position(5, 5) },
                new Robot.Common.Robot() {Position = new Position(0, 0) },
                new Robot.Common.Robot() {Position = new Position(4, 5), Owner=me },
                new Robot.Common.Robot() {Position = new Position(5, 4) },
                new Robot.Common.Robot() {Position = new Position(4, 4), Owner=me },
                new Robot.Common.Robot() {Position = new Position(3, 5) },
                new Robot.Common.Robot() {Position = new Position(5, 6), Owner=me },
                new Robot.Common.Robot() {Position = new Position(4, 3) },
                new Robot.Common.Robot() {Position = new Position(3, 4) },
                new Robot.Common.Robot() {Position = new Position(6, 8) },
            };
            var position = new Position(5, 5);
            int count = EnemysRobotCount(robots, position, me);
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void SortStationsTest()
        {
            var map = new Map() {
                Stations = new List<EnergyStation>()
            };
            map.Stations.Add(new EnergyStation() { Position = new Position(4, 5) });
            map.Stations.Add(new EnergyStation() { Position = new Position(0, 0) });
            map.Stations.Add(new EnergyStation() { Position = new Position(0, 5) });
            map.Stations.Add(new EnergyStation() { Position = new Position(3, 5) });
            map.Stations.Add(new EnergyStation() { Position = new Position(2, 5) });
            map.Stations.Add(new EnergyStation() { Position = new Position(5, 5) });
            var position = new Position(5, 5);
            var sort = SortStations(map, position);
            Console.WriteLine(sort.ToString());
        }

    }

}
