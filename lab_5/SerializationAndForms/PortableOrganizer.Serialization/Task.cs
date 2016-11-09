﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{

    [Serializable]
    public class Task
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public int Priority { get; set; }

    }

}
