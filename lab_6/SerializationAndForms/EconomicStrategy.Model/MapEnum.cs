using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public abstract class MapEnum
    {

        public abstract string getName();

        public abstract int[] getCost();

        public abstract ResourceList[] getPrice();

    }
}
