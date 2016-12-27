using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public class BuildType : MapEnum
    {

        public static BuildType Forester = new BuildType("Лісник");
        public static BuildType Warehouse = new BuildType("Склад");
        public static BuildType House = new BuildType("Будинок");
        public static BuildType Sawmill = new BuildType("Пилорама");
        public static BuildType Market = new BuildType("Ринок");
        public static BuildType Fisherman = new BuildType("Рибак");
        public static BuildType Hunter = new BuildType("Мисливець");
        public static BuildType Mine = new BuildType("Шахта");
        public static BuildType Farmer = new BuildType("Фермер");
        public static BuildType Bakery = new BuildType("Пекарня");

        public static IEnumerable<BuildType> VALUES = new List<BuildType>()
        {
            Forester, Warehouse, House, Sawmill, Market, Fisherman, Hunter, Mine, Farmer, Bakery
        };

        String name;

        BuildType(String name)
        {
            this.name = name;
        }

        public override String getName()
        {
            return name;
        }

        public override ResourceList[] getCost()
        {
            try
            {
                return Prices.costMap[getName()];
            } catch (KeyNotFoundException ex)
            {
                Console.WriteLine("map[-1]");
                return new ResourceList[0];
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
