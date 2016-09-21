using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robot.Common;
using static BogdanDuben.RobotChallenge.DistanceHelper;

namespace BogdanDuben.RobotChallenge
{
    public class BogdanDubenAlgorithm : IRobotAlgorithm
    {

        public BogdanDubenAlgorithm()
        {
            Logger.OnLogRound += OnLogRound;
        }

        private void OnLogRound(object sender, LogRoundEventArgs e)
        {
            RoundCount++;
        }

        private int RoundCount { get; set; }

        public RobotCommand DoStep(IList<Robot.Common.Robot> robots, int robotToMoveIndex, Map map)
        {
            Robot.Common.Robot movingRobot = robots[robotToMoveIndex];
            if ((movingRobot.Energy > 200) && (robots.Count < 5 * map.Stations.Count))
                return new CreateNewRobotCommand();
            Position stationPosition = FindNearestFreeStation(robots[robotToMoveIndex], map, robots);
            EnergyStation station = null;
            foreach (var st in map.Stations)
            {
                if (st.Position.Equals(stationPosition))
                {
                    station = st;
                }
            }
            if (station.Energy < 10)
            {
                var m = map;
                m.Stations.Remove(station);
                stationPosition = FindNearestFreeStation(robots[robotToMoveIndex], m, robots);
            }
            if (stationPosition == null)
                return null;
            if (stationPosition == movingRobot.Position)
                return new CollectEnergyCommand();
            else
                return new MoveCommand() { NewPosition = stationPosition };
        }







        public string Author
        {
            get { return "BogdanDuben"; }
        }

        public string Description
        {
            get { return "My first algorithm"; }
        }
    }

}
