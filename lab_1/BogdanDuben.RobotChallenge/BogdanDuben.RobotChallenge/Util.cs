using Robot.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogdanDuben.RobotChallenge
{
    public class Util
    {

        public static int MAX_COLLECT_DISTANCE = 2;

        public static int RobotCount(Map map, List<Robot.Common.Robot> robots, Position position)
        {
            int count = 0;
            int x, y;
            foreach (var r in robots)
            {
                x = r.Position.X;
                y = r.Position.Y;
                if (Math.Abs(position.X - x) + Math.Abs(position.Y - y) <= MAX_COLLECT_DISTANCE)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
