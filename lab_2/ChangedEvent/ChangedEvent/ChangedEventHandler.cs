using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangedEvent
{

    public delegate void ChangedEventHandler(object sender, Args args);

    public class Args : EventArgs
    {

    }

}
