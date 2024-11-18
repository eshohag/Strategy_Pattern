using Strategy_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Strategies
{
    public class OperationAdd : Strategy
    {
        public int GetResult(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
