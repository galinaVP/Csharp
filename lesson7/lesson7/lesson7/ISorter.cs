﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    interface ISorter<T> : IPrintable
    {
        void Sort();
    }
}
