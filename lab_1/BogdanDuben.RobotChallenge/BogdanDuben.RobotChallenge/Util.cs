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

        public static int MAX_COLLECT_DISTANCE = 1;

        public static int RobotCount(IList<Robot.Common.Robot> robots, Position position)
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

        public static int MyRobotCount(IList<Robot.Common.Robot> robots, Position position, Owner me)
        {
            int count = 0;
            int x, y;
            foreach (var r in robots)
            {
                if (!r.Owner.Equals(me))
                {
                    continue;
                }
                x = r.Position.X;
                y = r.Position.Y;
                if (Math.Abs(position.X - x) + Math.Abs(position.Y - y) <= MAX_COLLECT_DISTANCE)
                {
                    count++;
                }
            }
            return count;
        }

        public static int EnemysRobotCount(IList<Robot.Common.Robot> robots, Position position, Owner me)
        {
            int count = 0;
            int x, y;
            foreach (var r in robots)
            {
                if (me.Equals(r.Owner))
                {
                    continue;
                }
                x = r.Position.X;
                y = r.Position.Y;
                if (Math.Abs(position.X - x) + Math.Abs(position.Y - y) <= MAX_COLLECT_DISTANCE)
                {
                    count++;
                }
            }
            return count;
        }

        public static List<EnergyStation> SortStations(Map map, Position p)
        {
            var list = map.Stations.ToList();
            list.Sort((EnergyStation a, EnergyStation b) =>
            {
                var s1 = Math.Abs(a.Position.X - p.X) + Math.Abs(a.Position.Y - p.Y);
                var s2 = Math.Abs(b.Position.X - p.X) + Math.Abs(b.Position.Y - p.Y);
                return (s1 > s2) ? 1 : -1;
            });
            return list;
        }

        public static bool IsAtStation(Map map, Position p)
        {
            int x, y;
            foreach (var st in map.Stations)
            {
                x = st.Position.X;
                y = st.Position.Y;
                if (Math.Abs(p.X - x) + Math.Abs(p.Y - y) <= MAX_COLLECT_DISTANCE)
                {
                    return true;
                }
            }
            return false;
        }

        public static int DistanceToPosition(Position p1, Position p2)
        {
            return Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y);
        }

        public static int EnergyToPosition(Position p1, Position p2)
        {
            return (int) (Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

    }
}
