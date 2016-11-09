using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Build : MapObject, Display
    {

        private BuildType buildType;
        int level;

        public Build(BuildType buildType)
        {
            this.buildType = buildType;
            this.level = 0;
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

        public bool upgrade()
        {
            //TODO: реалізувати
            return true;
        }

        public void display()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
