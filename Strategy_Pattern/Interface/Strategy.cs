﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Interface
{
    public interface Strategy
    {
        public int GetResult(int num1, int num2);
    }
}
