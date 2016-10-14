using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robot.Common;

namespace RobotChallengeChangeEvent
{
    public static class Command
    {

        public static RobotCommand CollectEnergy(IList<Robot.Common.Robot> robots, int robotToMoveIndex, Map map)
        {
            return new CollectEnergyCommand();
        }

        public static RobotCommand Move(IList<Robot.Common.Robot> robots, int robotToMoveIndex, Map map)
        {
            return new MoveCommand(); //але куди ми йдемо?
        }

        public static RobotCommand CreateNewRobot(IList<Robot.Common.Robot> robots, int robotToMoveIndex, Map map)
        {
            return new CreateNewRobotCommand(); //
        }

        public static RobotCommand Stay(IList<Robot.Common.Robot> robots, int robotToMoveIndex, Map map)
        {
            return null;
        }

    }

}
