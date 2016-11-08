using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQuest
{
    class BuildType : MapEnum
    {

        public static BuildType Forester = new BuildType("Лісник");
        public static BuildType Warehouse = new BuildType("Склад");

        String name;

        BuildType(String name)
        {
            this.name = name;
        }

        public override String getName()
        {
            return name;
        }

        public override int[] getCost()
        {
            try
            {
                return Prices.costMap[getName()];
            } catch (KeyNotFoundException ex)
            {
                Console.WriteLine("map[-1]");
                return new int[0];
            }
        }

        public override ResourceList[] getPrice()
        {
            try {
                return Prices.priceMap[getName()];
            } catch (KeyNotFoundException ex)
            {
                Console.WriteLine("map[-2]");
                return new ResourceList[0];
            }
        }

        public override String ToString()
        {
            return name;
        }


    }
}
