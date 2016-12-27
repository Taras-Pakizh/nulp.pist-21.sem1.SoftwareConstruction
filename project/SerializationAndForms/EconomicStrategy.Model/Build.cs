using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public class Build : MapObject, Display
    {

        private BuildType buildType;
        int level;
        bool sleepFlag;
        bool conditionFlag;

        public Build(BuildType buildType)
        {
            this.buildType = buildType;
            this.level = 0;
            this.sleepFlag = false;
            this.conditionFlag = true;
        }

        public ResourceList skip()
        {
            try {
                return buildType.getPrice()[level];
            } catch (NullReferenceException ex)
            {
                Console.WriteLine("null");
                return new ResourceList();
            } catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("array[-1]");
                return new ResourceList();
            }
        }

        public override String ToString()
        {
            return buildType.getName();
        }

        public String toString()
        {
            return buildType.getName() + "(" + (level + 1) + ")\n" + (sleepFlag ? "[сон]" : conditionFlag ? "" : "[зруйноване]");
        }

        public ResourceList upgrade()
        {
            var res = Prices.costMap[getType().getName()][level];
            if (level < 3)
            {
                level++;
            }
            return res;
        }

        public bool recondition()
        {
            conditionFlag = true;
            return true;
        }

        public bool sleep()
        {
            sleepFlag = !sleepFlag;
            return true;
        }

        public bool isRecondition()
        {
            return conditionFlag;
        }

        public bool isSleep()
        {
            return sleepFlag;
        }

        public void display()
        {
            Console.WriteLine(this.ToString());
        }

        public MapEnum getType()
        {
            return buildType;
        }
    }
}
