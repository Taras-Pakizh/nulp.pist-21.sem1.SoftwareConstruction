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

        public RobotCommand DoStep(IList<Robot.Common.Robot> robots, int robotToMoveIndex, Map map)
        {
            Robot.Common.Robot movingRobot = robots[robotToMoveIndex];
            if ((movingRobot.Energy > 500) && (robots.Count < map.Stations.Count))
            {
                return new CreateNewRobotCommand();
            }



            Position stationPosition = FindNearestFreeStation(robots[robotToMoveIndex], map, robots);

            if (stationPosition == null)
                return null;

            if (stationPosition == movingRobot.Position)
                return new CollectEnergyCommand();
            else
            {

                return new MoveCommand() { NewPosition = stationPosition };
            }
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
