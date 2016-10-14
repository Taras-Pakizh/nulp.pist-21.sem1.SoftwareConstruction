using System.Collections.Generic;
using Robot.Common;

namespace RobotChallengeChangeEvent
{
    public delegate RobotCommand ChangedEventHandler(IList<Robot.Common.Robot> robots, int robotToMoveIndex, Map map);
}