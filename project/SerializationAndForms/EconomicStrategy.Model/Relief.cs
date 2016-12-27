using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public class Relief : MapObject
    {

        ReliefType reliefType;

        public Relief(ReliefType relief)
        {
            this.reliefType = relief;
        }
        
        public override String ToString()
        {
            return reliefType.getName();
        }
        
        public ResourceList upgrade()
        {
            //TODO: реалізувати
            return new ResourceList();
        }

        public bool recondition()
        {
            //TODO: реалізувати
            return false;
        }

        public bool sleep()
        {
            //TODO: реалізувати
            return false;
        }

        public bool isRecondition()
        {
            //TODO: реалізувати
            return false;
        }

        public bool isSleep()
        {
            //TODO: реалізувати
            return false;
        }

        public MapEnum getType()
        {
            return reliefType;
        }
    }

}
