using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDispatch3.Domain
{
    interface INinshouZumiCard<T> where T : ICardNinshouResult
    {
        T Result();
    }
}
