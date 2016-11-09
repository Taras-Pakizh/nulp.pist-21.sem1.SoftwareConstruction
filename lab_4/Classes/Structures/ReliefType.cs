using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    struct ReliefType : MapEnum
    {

        public static ReliefType Tree = new ReliefType("Дерево");

        String name;

        private ReliefType(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public int[] getCost()
        {
            return Prices.costMap[getName()];
        }

        public ResourceList[] getPrice()
        {
            return Prices.priceMap[getName()];
        }

        public override String ToString()
        {
            return name;
        }
    }
}
