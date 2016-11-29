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
        
        public bool upgrade()
        {
            //TODO: реалізувати
            return false;
        }

    }

}
