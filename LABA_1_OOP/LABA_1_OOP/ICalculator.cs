using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_1_OOP
{
    interface ICalculator
    {
        int OR(int a, int b);
        int AND(int a, int b);
        int NOT(int a, int b);
        int XOR(int a, int b);
    }
}
