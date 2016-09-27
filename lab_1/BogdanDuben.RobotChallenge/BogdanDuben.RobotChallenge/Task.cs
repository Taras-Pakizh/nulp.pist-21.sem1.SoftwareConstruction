using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robot.Common;

namespace BogdanDuben.RobotChallenge
{
    public abstract class Task
    {

        public abstract RobotCommand proccess(IList<Robot.Common.Robot> robots, MRobot robot, Map map);

    }

    public class MoveTask : Task
    {

        public Position position { set; get; }

        public override RobotCommand proccess(IList<Robot.Common.Robot> robots, MRobot robot, Map map)
        {
            var pos = robots[robot.id].Position;
            int hasEnergy = robots[robot.id].Energy - 300;
            int needEnergy = Util.EnergyToPosition(position, pos);
            if (needEnergy < hasEnergy)
            {
                return new MoveCommand { NewPosition = position };
            } else
            {
                int m = (int) Math.Ceiling(1.0 * needEnergy / hasEnergy);
                int deltaX = pos.X - position.X;
                int deltaY = pos.Y - position.Y;
                for (int i = 0; i < m; i++)
                {
                    robot.addTask(new MoveTask() { position = new Position(pos.X + deltaX * i, pos.Y + deltaY * i) });
                }
                return robot.getTask().proccess(robots, robot, map);
            }
        }

    }

    public class CollectTask : Task
    {

        public override RobotCommand proccess(IList<Robot.Common.Robot> robots, MRobot robot, Map map)
        {
            if (Util.IsAtStation(map, robots[robot.id].Position))
            {
                robot.addTask(new CollectTask());
                robot.addTask(new FindTask());
                return new CollectEnergyCommand();
            }
            return new FindTask().proccess(robots, robot, map);
        }

    }

    public class FindTask : Task
    {

        public override RobotCommand proccess(IList<Robot.Common.Robot> robots, MRobot robot, Map map)
        {
            if (Util.IsAtStation(map, robots[robot.id].Position))
            {
                robot.addTask(new CreateTask());
                robot.addTask(new CollectTask());
                return new CollectEnergyCommand();
            }
            var sort = Util.SortStations(map, robots[robot.id].Position);
            foreach (var st in sort)
            {
                if (Util.EnergyToPosition(st.Position, robots[robot.id].Position) > robots[robot.id].Energy)
                {
                    continue;
                }
                if (Util.RobotCount(robots, st.Position) == 0)
                {
                    robot.addTask(new CollectTask());
                    return new MoveCommand() { NewPosition = st.Position };
                }
                if (Util.EnemysRobotCount(robots, st.Position, robots[robot.id].Owner) < 4 && Util.MyRobotCount(robots, st.Position, robots[robot.id].Owner) == 0)
                {
                    robot.addTask(new CollectTask());
                    return new MoveCommand() { NewPosition = st.Position };
                }
            }
            return new MoveCommand { NewPosition = robots[robot.id].Position };
        }

    }

    public class CreateTask : Task
    {

        public override RobotCommand proccess(IList<Robot.Common.Robot> robots, MRobot robot, Map map)
        {
            int hasEnergy = robots[robot.id].Energy - 300;
            var sort = Util.SortStations(map, robots[robot.id].Position);
            foreach (var st in sort)
            {
                int needEnergy = Util.EnergyToPosition(st.Position, robots[robot.id].Position);
                if ((needEnergy < hasEnergy) && Util.RobotCount(robots, st.Position) == 0)
                {
                    return new CreateNewRobotCommand() { NewRobotEnergy = hasEnergy };
                }
            }
            return new FindTask().proccess(robots, robot, map);
        }

    }

    public class StayTask : Task
    {

        public override RobotCommand proccess(IList<Robot.Common.Robot> robots, MRobot robot, Map map)
        {
            return new MoveCommand { NewPosition = robots[robot.id].Position };
        }

    }

}
