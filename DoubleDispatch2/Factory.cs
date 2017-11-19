using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDispatch2
{
    static class Factory
    {
        static public IBase Create(int x)
        {
            if (x == 0)
            {
                return new ChildA();
            }
            else
            {
                return new ChildB();
            }
        }
    }
}
