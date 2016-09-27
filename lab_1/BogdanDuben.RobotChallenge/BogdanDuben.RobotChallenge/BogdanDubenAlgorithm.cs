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
            MRobot robot = MRobot.getRobot(robotToMoveIndex);
            var task = robot.getTask();
            return task.proccess(robots, robot, map);
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
