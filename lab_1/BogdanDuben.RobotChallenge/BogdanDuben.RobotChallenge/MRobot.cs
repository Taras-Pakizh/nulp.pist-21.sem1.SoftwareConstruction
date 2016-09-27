using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogdanDuben.RobotChallenge
{
    public class MRobot
    {

        private static List<MRobot> robots = new List<MRobot>(10000);

        public static void addRobot(MRobot robot)
        {
            robots.Add(robot);
        }

        public static List<MRobot> getRobots()
        {
            return robots;
        }

        public static MRobot getRobot(int id)
        {
            if (robots.Count <= id)
            {
                var robot = new MRobot(id, new FindTask());
                robots.Add(robot);
            }
            return robots.Find(r => r.id == id);
        }




        public int id { set; get; }
        private List<Task> tasks { set; get; }

        public MRobot(int id)
        {
            this.id = id;
            this.tasks = new List<Task>();
        }

        public MRobot(int id, Task task)
        {
            this.id = id;
            this.tasks = new List<Task>();
            tasks.Add(task);
        }

        public void addTask(Task task)
        {
            tasks.Add(task);
        }

        public Task getTask()
        {
            if (tasks.Count == 0)
            {
                tasks.Add(new FindTask());
            }
            var task = tasks[0];
            tasks.RemoveAt(0);
            return task;
        }

        public Task peekTask(int i)
        {
            if (tasks.Count <= i)
            {
                return null;
            }
            return tasks[i];
        }

    }

}
