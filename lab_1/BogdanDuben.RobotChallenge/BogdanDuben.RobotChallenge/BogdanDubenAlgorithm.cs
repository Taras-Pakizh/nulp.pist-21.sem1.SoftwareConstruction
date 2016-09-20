using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robot.Common;

namespace BogdanDuben.RobotChallange {
    public class BogdanDubenAlgorithm : IRobotAlgorithm
    {

        public RobotCommand DoStep(IList<Robot.Common.Robot> robots, int robotToMoveIndex, Map map)
        {
            var myRobot = robots[robotToMoveIndex];
            var newPosition = myRobot.Position;
            newPosition.X += 1;
            newPosition.Y += 1;
            return new MoveCommand() { NewPosition = newPosition };


            return null;
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
