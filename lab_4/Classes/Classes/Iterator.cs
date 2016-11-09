﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    interface Iterator
    {
        bool hasNext();

        MapObject next();

        //TODO: delete
        MapObject preview();

        //TODO: delete
        MapObject peek();

    }
}