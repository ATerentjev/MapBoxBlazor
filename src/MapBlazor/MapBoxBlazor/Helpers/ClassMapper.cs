﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MatBlazor
{
    public class ClassMapper : BaseMapper
    {
        public string AsString()
        {
            return string.Join(" ", Items.Select(i => i()).Where(i => i != null));
        }


        public override string ToString()
        {
            return AsString();
        }
    }
}