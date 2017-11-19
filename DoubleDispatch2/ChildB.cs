using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDispatch2
{
    class ChildB : IBase
    {
        public void Do()
        {
            Console.WriteLine(nameof(ChildB));
        }
    }
}
