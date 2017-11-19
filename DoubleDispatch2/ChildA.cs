using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDispatch2
{
    class ChildA : IBase
    {
        public void Do()
        {
            Console.WriteLine(nameof(ChildA));
        }
    }
}
