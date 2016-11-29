using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public class ReliefType : MapEnum
    {

        public static ReliefType Tree = new ReliefType("Дерево");

        public static List<ReliefType> VALUES = new List<ReliefType>()
        {
            Tree
        };

        String name;

        private ReliefType(String name)
        {
            this.name = name;
        }

        public override String getName()
        {
            return name;
        }

        public override int[] getCost()
        {
            return Prices.costMap[getName()];
        }

        public override ResourceList[] getPrice()
        {
            return Prices.priceMap[getName()];
        }

        public override String ToString()
        {
            return name;
        }
    }
}
