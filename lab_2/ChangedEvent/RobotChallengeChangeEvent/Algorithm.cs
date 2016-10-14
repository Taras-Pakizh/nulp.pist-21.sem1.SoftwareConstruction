using System;
using System.Collections.Generic;
using Robot.Common;
using static RobotChallengeChangeEvent.Command;

namespace RobotChallengeChangeEvent
{
    class Algorithm : IRobotAlgorithm
    {

        public Algorithm()
        {
            Logger.OnLogRound += OnLogRound;
        }
        private void OnLogRound(object sender, LogRoundEventArgs e)
        {
            RoundCount++;
        }
        private int RoundCount { get; set; }



        public static event ChangedEventHandler Changed;

        public RobotCommand DoStep(IList<Robot.Common.Robot> robots, int robotToMoveIndex, Map map)
        {
            Changed = null;
            switch (new Random().Next(4))
                //тут ми маємо перевіряти, яку дію нам варто робити
                //але ми покладаємось на долю
            {
                case 0:
                    Changed += Stay;
                    break;
                case 1:
                    Changed += Move;
                    break;
                case 2:
                    Changed += CollectEnergy;
                    break;
                case 3:
                    Changed += CreateNewRobot;
                    break;
                default:
                    Changed += Stay;
                    break;
            }
            return Changed(robots, robotToMoveIndex, map);
        }




        public string Author
        {
            get
            {
                return "";
            }
        }

        public string Description
        {
            get
            {
                return "";
            }
        }
    }
}
