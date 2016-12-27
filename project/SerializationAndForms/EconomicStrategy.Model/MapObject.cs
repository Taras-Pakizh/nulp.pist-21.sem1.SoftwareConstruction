using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicStrategy.Model
{
    public interface MapObject
    {

        ResourceList upgrade();
        bool recondition();
        bool sleep();
        bool isRecondition();
        bool isSleep();
        MapEnum getType();

    }
}
